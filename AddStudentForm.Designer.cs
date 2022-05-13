
namespace WindowsFormsApp1
{
    partial class AddStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stuID_tbx = new System.Windows.Forms.TextBox();
            this.fname_tbx = new System.Windows.Forms.TextBox();
            this.lname_tbx = new System.Windows.Forms.TextBox();
            this.phone_tbx = new System.Windows.Forms.TextBox();
            this.adrs_tbx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Female_ckd = new System.Windows.Forms.RadioButton();
            this.Male_ckd = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.savsv_btn = new System.Windows.Forms.Button();
            this.cancelsv_btn = new System.Windows.Forms.Button();
            this.pictureBoxStu = new System.Windows.Forms.PictureBox();
            this.AddPic_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birth Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Picture:";
            // 
            // stuID_tbx
            // 
            this.stuID_tbx.Location = new System.Drawing.Point(78, 6);
            this.stuID_tbx.Name = "stuID_tbx";
            this.stuID_tbx.Size = new System.Drawing.Size(190, 20);
            this.stuID_tbx.TabIndex = 8;
            // 
            // fname_tbx
            // 
            this.fname_tbx.Location = new System.Drawing.Point(78, 36);
            this.fname_tbx.Name = "fname_tbx";
            this.fname_tbx.Size = new System.Drawing.Size(190, 20);
            this.fname_tbx.TabIndex = 9;
            // 
            // lname_tbx
            // 
            this.lname_tbx.Location = new System.Drawing.Point(78, 69);
            this.lname_tbx.Name = "lname_tbx";
            this.lname_tbx.Size = new System.Drawing.Size(190, 20);
            this.lname_tbx.TabIndex = 10;
            // 
            // phone_tbx
            // 
            this.phone_tbx.Location = new System.Drawing.Point(78, 177);
            this.phone_tbx.Name = "phone_tbx";
            this.phone_tbx.Size = new System.Drawing.Size(190, 20);
            this.phone_tbx.TabIndex = 11;
            // 
            // adrs_tbx
            // 
            this.adrs_tbx.Location = new System.Drawing.Point(78, 215);
            this.adrs_tbx.Multiline = true;
            this.adrs_tbx.Name = "adrs_tbx";
            this.adrs_tbx.Size = new System.Drawing.Size(190, 98);
            this.adrs_tbx.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Female_ckd);
            this.panel1.Controls.Add(this.Male_ckd);
            this.panel1.Location = new System.Drawing.Point(79, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 40);
            this.panel1.TabIndex = 13;
            // 
            // Female_ckd
            // 
            this.Female_ckd.AutoSize = true;
            this.Female_ckd.Location = new System.Drawing.Point(106, 12);
            this.Female_ckd.Name = "Female_ckd";
            this.Female_ckd.Size = new System.Drawing.Size(59, 17);
            this.Female_ckd.TabIndex = 1;
            this.Female_ckd.Text = "Female";
            this.Female_ckd.UseVisualStyleBackColor = true;
            this.Female_ckd.CheckedChanged += new System.EventHandler(this.Female_ckd_CheckedChanged);
            // 
            // Male_ckd
            // 
            this.Male_ckd.AutoSize = true;
            this.Male_ckd.Checked = true;
            this.Male_ckd.Location = new System.Drawing.Point(24, 12);
            this.Male_ckd.Name = "Male_ckd";
            this.Male_ckd.Size = new System.Drawing.Size(48, 17);
            this.Male_ckd.TabIndex = 0;
            this.Male_ckd.TabStop = true;
            this.Male_ckd.Text = "Male";
            this.Male_ckd.UseVisualStyleBackColor = true;
            this.Male_ckd.CheckedChanged += new System.EventHandler(this.Male_ckd_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // savsv_btn
            // 
            this.savsv_btn.Location = new System.Drawing.Point(27, 500);
            this.savsv_btn.Name = "savsv_btn";
            this.savsv_btn.Size = new System.Drawing.Size(124, 38);
            this.savsv_btn.TabIndex = 15;
            this.savsv_btn.Text = "Save";
            this.savsv_btn.UseVisualStyleBackColor = true;
            this.savsv_btn.Click += new System.EventHandler(this.savsv_btn_Click);
            // 
            // cancelsv_btn
            // 
            this.cancelsv_btn.Location = new System.Drawing.Point(167, 500);
            this.cancelsv_btn.Name = "cancelsv_btn";
            this.cancelsv_btn.Size = new System.Drawing.Size(124, 38);
            this.cancelsv_btn.TabIndex = 16;
            this.cancelsv_btn.Text = "Cancel";
            this.cancelsv_btn.UseVisualStyleBackColor = true;
            // 
            // pictureBoxStu
            // 
            this.pictureBoxStu.Location = new System.Drawing.Point(79, 321);
            this.pictureBoxStu.Name = "pictureBoxStu";
            this.pictureBoxStu.Size = new System.Drawing.Size(181, 131);
            this.pictureBoxStu.TabIndex = 17;
            this.pictureBoxStu.TabStop = false;
            // 
            // AddPic_btn
            // 
            this.AddPic_btn.Location = new System.Drawing.Point(79, 458);
            this.AddPic_btn.Name = "AddPic_btn";
            this.AddPic_btn.Size = new System.Drawing.Size(181, 22);
            this.AddPic_btn.TabIndex = 18;
            this.AddPic_btn.Text = "Add picture";
            this.AddPic_btn.UseVisualStyleBackColor = true;
            this.AddPic_btn.Click += new System.EventHandler(this.AddPic_btn_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 550);
            this.Controls.Add(this.AddPic_btn);
            this.Controls.Add(this.pictureBoxStu);
            this.Controls.Add(this.cancelsv_btn);
            this.Controls.Add(this.savsv_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adrs_tbx);
            this.Controls.Add(this.phone_tbx);
            this.Controls.Add(this.lname_tbx);
            this.Controls.Add(this.fname_tbx);
            this.Controls.Add(this.stuID_tbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stuID_tbx;
        private System.Windows.Forms.TextBox fname_tbx;
        private System.Windows.Forms.TextBox lname_tbx;
        private System.Windows.Forms.TextBox phone_tbx;
        private System.Windows.Forms.TextBox adrs_tbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton Female_ckd;
        private System.Windows.Forms.RadioButton Male_ckd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button savsv_btn;
        private System.Windows.Forms.Button cancelsv_btn;
        private System.Windows.Forms.PictureBox pictureBoxStu;
        private System.Windows.Forms.Button AddPic_btn;
    }
}