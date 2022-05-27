using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using Microsoft.Office.Interop.Word;
using Spire.Doc;
using Spire.Pdf;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Aspose.Words;
using Aspose.Words.Tables;
using ThuVienWinform.Report.AsposeWordExtension;

namespace WindowsFormsApp1
{
    public partial class AVGResultByByCourse : Form
    {
        STUDENT st = new STUDENT();
        SCORE sc = new SCORE();
        System.Data.DataTable MainBoard = new System.Data.DataTable();
        public AVGResultByByCourse()
        {
            InitializeComponent();
        }

        private void AVGResultByByCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSVDBDataSet12.std' table. You can move, or remove it, as needed.
            this.stdTableAdapter1.Fill(this.qLSVDBDataSet12.std);
            // TODO: This line of code loads data into the 'qLSVDBDataSet7.std' table. You can move, or remove it, as needed.

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow.Cells[0].Value.ToString().Trim() != "")
            {
                System.Data.DataTable a = new System.Data.DataTable();
                a = sc.getScoreInfoStu(Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString().Trim()));
                MainBoard = a;
                if (a.Rows.Count != 0)
                {
                    mainboard.Enabled = true;
                    mainboard.DataSource = a;
                }
                else
                {
                    MessageBox.Show("Student dont have course");
                }
            }
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            if(ID_tbx.Text.Trim() == "")
            {
                this.stdTableAdapter.Fill(this.qLSVDBDataSet7.std);
                dataGridView2.DataSource = this.qLSVDBDataSet7.std;
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT Id, fname, lname FROM std WHERE Id = @id");
                command.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(ID_tbx.Text);
                dataGridView2.DataSource = st.getStudent(command);
            }
        }

        private void ID_tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if(ID_tbx.Text == "")
            {
                this.stdTableAdapter.Fill(this.qLSVDBDataSet7.std);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            /*PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }*/


            if (mainboard.Enabled)
            {


                ////////////////////////////////////////////////////Version 1
                /*List<string> tmp_list = GetParagraph();
                string final = "";
                foreach(string tmp in tmp_list)
                {
                    final = string.Concat(final, tmp + "\n");
                }

                Spire.Doc.Document doc = new Spire.Doc.Document();

                // Tạo đối tượng đoạn (Paragraph)
                Spire.Doc.Documents.Paragraph paragraph = doc.AddSection().AddParagraph();

                // Tạo văn bản (TextRange)
                Spire.Doc.Fields.TextRange text = paragraph.AppendText(final);
                //text.CharacterFormat.Italic = true;  // in nghiêng
                //text.CharacterFormat.UnderlineStyle = UnderlineStyle.Single; // gạch chân
                text.CharacterFormat.Bold = true;                                   // kiểu in đậm
                //paragraph.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                //paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;  // đoạn canh giữa
                                                                                    //paragraph.Format.HorizontalAlignment = HorizontalAlignment.Left;  // đoạn canh trái  
                                                                                    //paragraph.Format.HorizontalAlignment = HorizontalAlignment.Right; // đoạn canh phải

                // Lưu đối tượng tài liệu vào tập tin test.doc (nằm ở thư mục Debug của dự án)
                doc.SaveToFile("StudentResult(" + mainboard.Rows[0].Cells[0].Value.ToString().Trim() + ")" +  ".docx", Spire.Doc.FileFormat.Docx2013);
                // doc.SaveToFile("test.pdf", Spire.Doc.FileFormat.PDF); -- tạo PDF

                // đóng đối tượng
                doc.Close();*/







                ////////////////////////////////////////////////Version 2
                var homNay = DateTime.Now;
                //Bước 1: Nạp file mẫu
                Aspose.Words.Document baoCao = new Aspose.Words.Document("Mau_Bao_Cao.doc");

                //Bước 2: Điền các thông tin cố định
                baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format("Vũng Tàu, ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
                baoCao.MailMerge.Execute(new[] { "MSSV" }, new[] { mainboard.Rows[0].Cells[0].Value.ToString().Trim() });
                baoCao.MailMerge.Execute(new[] { "HoVaTen" }, new[] { mainboard.Rows[0].Cells[1].Value.ToString().Trim() + " " + mainboard.Rows[0].Cells[2].Value.ToString().Trim() });
                baoCao.MailMerge.Execute(new[] { "NgaySinh" }, new[] { Convert.ToDateTime(mainboard.Rows[0].Cells[3].Value).ToString("dd/MM/yyyy") });
                baoCao.MailMerge.Execute(new[] { "GioiTinh" }, new[] { (mainboard.Rows[0].Cells[4].Value.ToString().Trim() == "Male") ?  "NAM" : "NỮ"});
                baoCao.MailMerge.Execute(new[] { "SDT" }, new[] { mainboard.Rows[0].Cells[5].Value.ToString().Trim() });
                baoCao.MailMerge.Execute(new[] { "DiaChi" }, new[] { mainboard.Rows[0].Cells[6].Value.ToString().Trim() });
                baoCao.MailMerge.Execute(new[] { "AVG" }, new[] { mainboard.Rows[0].Cells["AVG Score"].Value.ToString().Trim() });
                baoCao.MailMerge.Execute(new[] { "KetQua" }, new[] { (Convert.ToDouble(mainboard.Rows[0].Cells["AVG Score"].Value.ToString().Trim()) >= 5)? "ĐẬU"  :"RỚT" });


                //Bước 3: Điền thông tin lên bảng
                Aspose.Words.Tables.Table bangThongTinGiaDinh = baoCao.GetChild(NodeType.Table, 1, true) as Aspose.Words.Tables.Table;//Lấy bảng thứ 2 trong file mẫu
                int hangHienTai = 1;
                bangThongTinGiaDinh.InsertRows(hangHienTai, hangHienTai, 3);
                for (int i = 7; ; i++)
                {
                    if(mainboard.Columns[i].Name.ToString().Trim() == "AVG Score")
                    {
                        break;
                    }
                    int tmp_int = i - 6;
                    bangThongTinGiaDinh.PutValue(hangHienTai, 0, tmp_int.ToString());//Cột STT
                    bangThongTinGiaDinh.PutValue(hangHienTai, 1, mainboard.Columns[i].Name.ToString().Trim());//Cột Tên môn
                    bangThongTinGiaDinh.PutValue(hangHienTai, 2, mainboard.Rows[0].Cells[i].Value.ToString().Trim());//Cột Điểm
                    double tmp = Convert.ToDouble(mainboard.Rows[0].Cells[i].Value.ToString().Trim());
                    tmp = Math.Round(tmp, 2);
                    bangThongTinGiaDinh.PutValue(hangHienTai, 3, (tmp >= 5) ? "PASS" : "FAIL");//Cột kết quả
                    hangHienTai++;
                }

                //Bước 4: Lưu và mở file
                baoCao.SaveAndOpenFile("StudentResult(" + mainboard.Rows[0].Cells[0].Value.ToString().Trim() + ").doc");
            }
            else
            {
                MessageBox.Show("No Data !");
            }
        }

        private List<string> GetParagraph()
        {
            List<string> a = new List<string>();
            for(int i = 0; i < mainboard.Columns.Count; i++)
            {
                string tmp = mainboard.Columns[i].Name + ": " + mainboard.Rows[0].Cells[i].Value.ToString().Trim();
                a.Add(tmp);
            }
            return a;
        }
    }
}
