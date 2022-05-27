
namespace WindowsFormsApp1
{
    partial class UpdateDeleteStudent
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fname_tbx = new System.Windows.Forms.TextBox();
            this.ID_tbx = new System.Windows.Forms.TextBox();
            this.lname_tbx = new System.Windows.Forms.TextBox();
            this.phone_tbx = new System.Windows.Forms.TextBox();
            this.adrs_tbx = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.find_btn = new System.Windows.Forms.Button();
            this.chagepic_btn = new System.Windows.Forms.Button();
            this.male_btn = new System.Windows.Forms.RadioButton();
            this.female_btn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.update_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ahkio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ahkio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ahkio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ahkio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ahkio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ahkio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("ahkio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(448, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("ahkio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(458, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Picture";
            // 
            // fname_tbx
            // 
            this.fname_tbx.Location = new System.Drawing.Point(127, 79);
            this.fname_tbx.Name = "fname_tbx";
            this.fname_tbx.Size = new System.Drawing.Size(304, 20);
            this.fname_tbx.TabIndex = 8;
            // 
            // ID_tbx
            // 
            this.ID_tbx.Location = new System.Drawing.Point(127, 36);
            this.ID_tbx.Name = "ID_tbx";
            this.ID_tbx.Size = new System.Drawing.Size(123, 20);
            this.ID_tbx.TabIndex = 9;
            this.ID_tbx.Leave += new System.EventHandler(this.ID_tbx_Leave);
            // 
            // lname_tbx
            // 
            this.lname_tbx.Location = new System.Drawing.Point(127, 118);
            this.lname_tbx.Name = "lname_tbx";
            this.lname_tbx.Size = new System.Drawing.Size(305, 20);
            this.lname_tbx.TabIndex = 10;
            // 
            // phone_tbx
            // 
            this.phone_tbx.Location = new System.Drawing.Point(127, 252);
            this.phone_tbx.Name = "phone_tbx";
            this.phone_tbx.Size = new System.Drawing.Size(304, 20);
            this.phone_tbx.TabIndex = 12;
            // 
            // adrs_tbx
            // 
            this.adrs_tbx.Location = new System.Drawing.Point(526, 36);
            this.adrs_tbx.Multiline = true;
            this.adrs_tbx.Name = "adrs_tbx";
            this.adrs_tbx.Size = new System.Drawing.Size(227, 102);
            this.adrs_tbx.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(526, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 97);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // find_btn
            // 
            this.find_btn.Font = new System.Drawing.Font("MercuriusScript", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_btn.Location = new System.Drawing.Point(256, 34);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(175, 23);
            this.find_btn.TabIndex = 15;
            this.find_btn.Text = "Find";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // chagepic_btn
            // 
            this.chagepic_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chagepic_btn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chagepic_btn.Location = new System.Drawing.Point(526, 252);
            this.chagepic_btn.Name = "chagepic_btn";
            this.chagepic_btn.Size = new System.Drawing.Size(227, 39);
            this.chagepic_btn.TabIndex = 16;
            this.chagepic_btn.Text = "Change image";
            this.chagepic_btn.UseVisualStyleBackColor = false;
            this.chagepic_btn.Click += new System.EventHandler(this.chagepic_btn_Click);
            // 
            // male_btn
            // 
            this.male_btn.AutoSize = true;
            this.male_btn.Font = new System.Drawing.Font("ahkio", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male_btn.Location = new System.Drawing.Point(43, 12);
            this.male_btn.Name = "male_btn";
            this.male_btn.Size = new System.Drawing.Size(55, 26);
            this.male_btn.TabIndex = 17;
            this.male_btn.TabStop = true;
            this.male_btn.Text = "Male";
            this.male_btn.UseVisualStyleBackColor = true;
            this.male_btn.CheckedChanged += new System.EventHandler(this.male_btn_CheckedChanged);
            // 
            // female_btn
            // 
            this.female_btn.AutoSize = true;
            this.female_btn.Font = new System.Drawing.Font("ahkio", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female_btn.Location = new System.Drawing.Point(206, 12);
            this.female_btn.Name = "female_btn";
            this.female_btn.Size = new System.Drawing.Size(72, 26);
            this.female_btn.TabIndex = 18;
            this.female_btn.TabStop = true;
            this.female_btn.Text = "Female";
            this.female_btn.UseVisualStyleBackColor = true;
            this.female_btn.CheckedChanged += new System.EventHandler(this.female_btn_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.male_btn);
            this.panel1.Controls.Add(this.female_btn);
            this.panel1.Location = new System.Drawing.Point(127, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 51);
            this.panel1.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.update_btn.Font = new System.Drawing.Font("UVN Mang Tre", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(242, 321);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(103, 51);
            this.update_btn.TabIndex = 21;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.remove_btn.Font = new System.Drawing.Font("UVN Mang Tre", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_btn.Location = new System.Drawing.Point(417, 321);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(103, 51);
            this.remove_btn.TabIndex = 22;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = false;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UpdateDeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(771, 384);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chagepic_btn);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adrs_tbx);
            this.Controls.Add(this.phone_tbx);
            this.Controls.Add(this.lname_tbx);
            this.Controls.Add(this.ID_tbx);
            this.Controls.Add(this.fname_tbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateDeleteStudent";
            this.Text = "UpdateDeleteStudent";
            this.Load += new System.EventHandler(this.UpdateDeleteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Button chagepic_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button remove_btn;
        public System.Windows.Forms.TextBox fname_tbx;
        public System.Windows.Forms.TextBox ID_tbx;
        public System.Windows.Forms.TextBox lname_tbx;
        public System.Windows.Forms.TextBox phone_tbx;
        public System.Windows.Forms.TextBox adrs_tbx;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RadioButton male_btn;
        public System.Windows.Forms.RadioButton female_btn;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}