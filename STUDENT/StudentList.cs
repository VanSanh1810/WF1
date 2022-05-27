using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Pdf;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace WindowsFormsApp1
{
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        MY_DB db = new MY_DB();
        private void StudentList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet8.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter1.Fill(this.qLSVDBDataSet8.std);
            // TODO: This line of code loads data into the 'qLSVDBDataSet.std' table. You can move, or remove it, as needed.
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = student.getStudent(command);
            
        }

        private void refres_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std");
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = student.getStudent(command);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDeleteStudent a = new UpdateDeleteStudent();
            a.ID_tbx.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            a.fname_tbx.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            a.lname_tbx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            a.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            if(dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Male")
            {
                a.male_btn.Checked = true;
                a.female_btn.Checked = false;
            }
            else
            {
                a.female_btn.Checked = true;
                a.male_btn.Checked = false;
            }
            a.phone_tbx.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            a.adrs_tbx.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            a.pictureBox1.Image = Image.FromStream(picture);
            this.Show();
            a.Show();
        }

        private void FWN_btn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE fname = @fname", db.getConnection);
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = FWN_tbx.Text.Trim();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if(table.Rows.Count == 0)
            {
                MessageBox.Show("Cant find student !");
            }
            else
            {
                FindWithName a = new FindWithName(FWN_tbx.Text.Trim());
                a.dataGridView_findwithname.DataSource = table;
                this.Show();
                a.Show();
            }
        }

        private void FWN_tbx_Leave(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE fname = @fname", db.getConnection);
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = FWN_tbx.Text.Trim();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                errorProvider1.SetError(FWN_tbx, "Cant find student");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            ////https://tanhongit.net/c-sharp/cach-tao-va-ghi-file-word-pdf-trong-c-voi-thu-vien-spire-doc-spire-pdf/


            // Dữ liệu 
            List<string> ID = new List<string>();
            ID = GetParagraph(0); //Student ID

            List<string> fname = new List<string>();
            fname = GetParagraph(1);//First name

            List<string> lname = new List<string>();
            lname = GetParagraph(2);//Last name

            List<string> bdate = new List<string>();
            bdate = GetParagraph(3);//Birthday

            List<string> gender = new List<string>();
            gender = GetParagraph(4);//Gender

            List<string> phone = new List<string>();
            phone = GetParagraph(5);//Phone

            List<string> address = new List<string>();
            address = GetParagraph(6);//Address

            List<byte[]> pic = new List<byte[]>(); ///
            pic = GetImage1();//Picture

            Spire.Doc.Document doc = new Spire.Doc.Document();
            // Tạo đối tượng bảng Table
            Spire.Doc.Table table = doc.AddSection().AddTable();

            // Tạo cột
            String[] Header = { "Student ID", "First name", "Last Name", "BirthDay", "Gender", "Phone", "Address", "Picture" };//{ "STT", "Tên" };//

            // Số dòng và số cột cho bảng
            table.ResetCells(ID.Count + 1, Header.Length);

            //set right border of table
            table.TableFormat.Borders.Right.BorderType = Spire.Doc.Documents.BorderStyle.Hairline;
            table.TableFormat.Borders.Right.LineWidth = 2.0F;
            table.TableFormat.Borders.Right.Color = Color.GreenYellow;
            //set top border of table
            table.TableFormat.Borders.Top.BorderType = Spire.Doc.Documents.BorderStyle.Hairline;
            table.TableFormat.Borders.Top.LineWidth = 4.0F;
            table.TableFormat.Borders.Top.Color = Color.GreenYellow;
            //set left border of table
            table.TableFormat.Borders.Left.BorderType = Spire.Doc.Documents.BorderStyle.Hairline;
            table.TableFormat.Borders.Left.LineWidth = 2.0F;
            table.TableFormat.Borders.Left.Color = Color.GreenYellow;
            //set bottom border is none
            table.TableFormat.Borders.Bottom.BorderType = Spire.Doc.Documents.BorderStyle.None;
            //set vertical and horizontal border
            table.TableFormat.Borders.Vertical.BorderType = Spire.Doc.Documents.BorderStyle.Dot;
            table.TableFormat.Borders.Horizontal.BorderType = Spire.Doc.Documents.BorderStyle.Dot;
            table.TableFormat.Borders.Vertical.Color = Color.Orange;



            // Độ rộng bảng ở dòng 0 và 2 cột STT và Tên (tạo tiêu đề bảng)
            doc.Sections[0].Tables[0].Rows[0].Cells[0].SetCellWidth(117, CellWidthType.Point);
            doc.Sections[0].Tables[0].Rows[0].Cells[1].SetCellWidth(117, CellWidthType.Point);
            doc.Sections[0].Tables[0].Rows[0].Cells[2].SetCellWidth(117, CellWidthType.Point);
            doc.Sections[0].Tables[0].Rows[0].Cells[3].SetCellWidth(117, CellWidthType.Point);
            doc.Sections[0].Tables[0].Rows[0].Cells[4].SetCellWidth(117, CellWidthType.Point);
            doc.Sections[0].Tables[0].Rows[0].Cells[5].SetCellWidth(117, CellWidthType.Point);
            doc.Sections[0].Tables[0].Rows[0].Cells[6].SetCellWidth(117, CellWidthType.Point);
            doc.Sections[0].Tables[0].Rows[0].Cells[7].SetCellWidth(250, CellWidthType.Point);


            // Tạo dòng tiêu đề cho bảng (dòng 0)
            Spire.Doc.TableRow FRow = table.Rows[0];
            FRow.IsHeader = true;
            FRow.Height = 50;

            for (int i = 0; i < Header.Length; i++)
            {
                // Định dạng cell
                Paragraph p = FRow.Cells[i].AddParagraph();
                FRow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;


                // Định dạng văn bản trong bảng
                Spire.Doc.Fields.TextRange TR = p.AppendText(Header[i]);
                TR.CharacterFormat.FontName = "Times New Roman";
                TR.CharacterFormat.FontSize = 13;
                TR.CharacterFormat.Bold = true;
            }

            // Định dạng dữ liệu từng dòng (lấy từ list)
            for (int r = 0; r < ID.Count ; r++)
            {
                
                //Console.WriteLine(r);
                doc.Sections[0].Tables[0].Rows[r + 1].Cells[0].SetCellWidth(117, CellWidthType.Point);
                doc.Sections[0].Tables[0].Rows[r + 1].Cells[1].SetCellWidth(117, CellWidthType.Point);
                doc.Sections[0].Tables[0].Rows[r + 1].Cells[2].SetCellWidth(117, CellWidthType.Point);
                doc.Sections[0].Tables[0].Rows[r + 1].Cells[3].SetCellWidth(117, CellWidthType.Point);
                doc.Sections[0].Tables[0].Rows[r + 1].Cells[4].SetCellWidth(117, CellWidthType.Point);
                doc.Sections[0].Tables[0].Rows[r + 1].Cells[5].SetCellWidth(117, CellWidthType.Point);
                doc.Sections[0].Tables[0].Rows[r + 1].Cells[6].SetCellWidth(117, CellWidthType.Point);
                doc.Sections[0].Tables[0].Rows[r + 1].Cells[7].SetCellWidth(250, CellWidthType.Point);

                // Định dạng dòng thứ r + 1 (bỏ dòng đầu là tiêu đề)
                Spire.Doc.TableRow DataRow = table.Rows[r + 1];
                DataRow.Height = 170;//;

                DataRow.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph p1 = DataRow.Cells[0].AddParagraph();
                Spire.Doc.Fields.TextRange TR1 = p1.AppendText(ID[r].ToString()); // ID
                p1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                DataRow.Cells[1].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph p2 = DataRow.Cells[1].AddParagraph();
                Spire.Doc.Fields.TextRange TR2 = p2.AppendText(fname[r].ToString()); // First Name
                p2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                DataRow.Cells[2].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph p3 = DataRow.Cells[2].AddParagraph();
                Spire.Doc.Fields.TextRange TR3 = p3.AppendText(lname[r].ToString()); // Last Name
                p3.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                DataRow.Cells[3].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph p4 = DataRow.Cells[3].AddParagraph();
                Spire.Doc.Fields.TextRange TR4 = p4.AppendText(bdate[r].ToString()); // BirthDay
                p4.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                DataRow.Cells[4].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph p5 = DataRow.Cells[4].AddParagraph();
                Spire.Doc.Fields.TextRange TR5 = p5.AppendText(gender[r].ToString()); // Gender
                p5.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                DataRow.Cells[5].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph p6 = DataRow.Cells[5].AddParagraph();
                Spire.Doc.Fields.TextRange TR6 = p6.AppendText(phone[r].ToString()); // Phone
                p6.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                DataRow.Cells[6].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph p7 = DataRow.Cells[6].AddParagraph();
                Spire.Doc.Fields.TextRange TR7 = p7.AppendText(address[r].ToString()); // Address
                p7.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                DataRow.Cells[7].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                Paragraph p8 = DataRow.Cells[7].AddParagraph();
                Spire.Doc.Fields.DocPicture TR8 = p8.AppendPicture(new MemoryStream(pic[r])); // Picture
                TR8.Width = 130;
                TR8.Height = 95;
                TR8.HorizontalPosition = 0.0F;
                TR8.VerticalPosition = 0.0F;
                TR8.TextWrappingStyle = TextWrappingStyle.InFrontOfText;
                //p2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
            }

            //Landscape
            doc.Sections[0].PageSetup.Orientation = PageOrientation.Landscape;
            // Lưu đối tượng tài liệu vào tập tin test.doc (nằm ở thư mục Debug của dự án)
            doc.SaveToFile("StudentList.docx", Spire.Doc.FileFormat.Docx2013);
            // doc.SaveToFile("test.pdf", Spire.Doc.FileFormat.PDF); -- tạo PDF

            // đóng đối tượng
            doc.Close();
            System.Diagnostics.Process.Start("StudentList.docx");
        }
        private List<string> GetParagraph(int colIndex)
        {
            List<string> a = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string tmp = dataGridView1.Rows[i].Cells[colIndex].Value.ToString().Trim();
                a.Add(tmp);
            }
            return a;
        }
        private List<Bitmap> GetImage()
        {
            List<Bitmap> a = new List<Bitmap>();
            /*for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                byte[] tmp = (byte[])dataGridView1.CurrentRow;
                a.Add(tmp);
            }
            return a;*/
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                MessageBox.Show(row.Cells[7].Value.GetType().ToString());
                Bitmap tmp = (Bitmap)row.Cells[7].Value;
                a.Add(tmp);
            }
            return a;
        }

        private List<byte[]> GetImage1()
        {
            List<byte[]> a = new List<byte[]>();
            /*for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                byte[] tmp = (byte[])dataGridView1.CurrentRow;
                a.Add(tmp);
            }
            return a;*/
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[7].Value.GetType().ToString() == "System.Byte[]")
                {
                    //MessageBox.Show(row.Cells[7].Value.GetType().ToString());
                    byte[] tmp = (byte[])row.Cells[7].Value;
                    a.Add(tmp);
                }
            }
            return a;
        }
    }
}
