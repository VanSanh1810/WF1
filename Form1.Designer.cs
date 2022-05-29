
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.usern_tbx = new System.Windows.Forms.TextBox();
            this.pssw_txb = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Register_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtn_student = new System.Windows.Forms.RadioButton();
            this.rbtn_HR = new System.Windows.Forms.RadioButton();
            this.llb_forgotpass = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // usern_tbx
            // 
            this.usern_tbx.Location = new System.Drawing.Point(80, 68);
            this.usern_tbx.Name = "usern_tbx";
            this.usern_tbx.Size = new System.Drawing.Size(169, 20);
            this.usern_tbx.TabIndex = 0;
            this.usern_tbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usern_tbx_KeyPress);
            // 
            // pssw_txb
            // 
            this.pssw_txb.Location = new System.Drawing.Point(80, 114);
            this.pssw_txb.Name = "pssw_txb";
            this.pssw_txb.PasswordChar = '*';
            this.pssw_txb.Size = new System.Drawing.Size(169, 20);
            this.pssw_txb.TabIndex = 1;
            this.pssw_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pssw_txb_KeyPress);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.login_btn.Location = new System.Drawing.Point(80, 200);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(53, 42);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cancel_btn.Location = new System.Drawing.Point(150, 200);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(53, 42);
            this.cancel_btn.TabIndex = 3;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Register_btn
            // 
            this.Register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Register_btn.Location = new System.Drawing.Point(222, 200);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(65, 42);
            this.Register_btn.TabIndex = 6;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = false;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "User Login";
            // 
            // rbtn_student
            // 
            this.rbtn_student.AutoSize = true;
            this.rbtn_student.Checked = true;
            this.rbtn_student.Location = new System.Drawing.Point(80, 164);
            this.rbtn_student.Name = "rbtn_student";
            this.rbtn_student.Size = new System.Drawing.Size(62, 17);
            this.rbtn_student.TabIndex = 8;
            this.rbtn_student.TabStop = true;
            this.rbtn_student.Text = "Student";
            this.rbtn_student.UseVisualStyleBackColor = true;
            // 
            // rbtn_HR
            // 
            this.rbtn_HR.AutoSize = true;
            this.rbtn_HR.Location = new System.Drawing.Point(171, 164);
            this.rbtn_HR.Name = "rbtn_HR";
            this.rbtn_HR.Size = new System.Drawing.Size(107, 17);
            this.rbtn_HR.TabIndex = 9;
            this.rbtn_HR.Text = "Human Resourse";
            this.rbtn_HR.UseVisualStyleBackColor = true;
            // 
            // llb_forgotpass
            // 
            this.llb_forgotpass.AutoSize = true;
            this.llb_forgotpass.Location = new System.Drawing.Point(149, 137);
            this.llb_forgotpass.Name = "llb_forgotpass";
            this.llb_forgotpass.Size = new System.Drawing.Size(100, 13);
            this.llb_forgotpass.TabIndex = 10;
            this.llb_forgotpass.TabStop = true;
            this.llb_forgotpass.Text = "Forgot password ??";
            this.llb_forgotpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_forgotpass_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(341, 307);
            this.Controls.Add(this.llb_forgotpass);
            this.Controls.Add(this.rbtn_HR);
            this.Controls.Add(this.rbtn_student);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pssw_txb);
            this.Controls.Add(this.usern_tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usern_tbx;
        private System.Windows.Forms.TextBox pssw_txb;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtn_student;
        private System.Windows.Forms.RadioButton rbtn_HR;
        private System.Windows.Forms.LinkLabel llb_forgotpass;
    }
}

