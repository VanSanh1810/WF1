
namespace WindowsFormsApp1
{
    partial class HRRegister
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
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.tbx_fname = new System.Windows.Forms.TextBox();
            this.tbx_lname = new System.Windows.Forms.TextBox();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_pass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.llb_login = new System.Windows.Forms.LinkLabel();
            this.err_ID = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_fname = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_lname = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_username = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_pass = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_fname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_lname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UVN Chim Bien", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UVN Chim Bien", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UVN Chim Bien", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UVN Chim Bien", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UVN Chim Bien", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UVN Chim Bien", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Picture";
            // 
            // tbx_ID
            // 
            this.tbx_ID.Enabled = false;
            this.tbx_ID.Location = new System.Drawing.Point(92, 51);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.Size = new System.Drawing.Size(173, 20);
            this.tbx_ID.TabIndex = 7;
            this.tbx_ID.Leave += new System.EventHandler(this.tbx_ID_Leave);
            // 
            // tbx_fname
            // 
            this.tbx_fname.Location = new System.Drawing.Point(92, 91);
            this.tbx_fname.Name = "tbx_fname";
            this.tbx_fname.Size = new System.Drawing.Size(173, 20);
            this.tbx_fname.TabIndex = 8;
            this.tbx_fname.Leave += new System.EventHandler(this.tbx_fname_Leave);
            // 
            // tbx_lname
            // 
            this.tbx_lname.Location = new System.Drawing.Point(92, 136);
            this.tbx_lname.Name = "tbx_lname";
            this.tbx_lname.Size = new System.Drawing.Size(173, 20);
            this.tbx_lname.TabIndex = 9;
            this.tbx_lname.Leave += new System.EventHandler(this.tbx_lname_Leave);
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(92, 184);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(173, 20);
            this.tbx_username.TabIndex = 10;
            this.tbx_username.Leave += new System.EventHandler(this.tbx_username_Leave);
            // 
            // tbx_pass
            // 
            this.tbx_pass.Location = new System.Drawing.Point(92, 233);
            this.tbx_pass.Name = "tbx_pass";
            this.tbx_pass.Size = new System.Drawing.Size(173, 20);
            this.tbx_pass.TabIndex = 11;
            this.tbx_pass.Leave += new System.EventHandler(this.tbx_pass_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(89, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 100);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.Aqua;
            this.btn_upload.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(89, 388);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(173, 29);
            this.btn_upload.TabIndex = 13;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Blue;
            this.btn_register.Font = new System.Drawing.Font("UTM Akashi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(46, 423);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(235, 59);
            this.btn_register.TabIndex = 14;
            this.btn_register.Text = "REGISTER";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // llb_login
            // 
            this.llb_login.AutoSize = true;
            this.llb_login.Location = new System.Drawing.Point(89, 493);
            this.llb_login.Name = "llb_login";
            this.llb_login.Size = new System.Drawing.Size(156, 13);
            this.llb_login.TabIndex = 15;
            this.llb_login.TabStop = true;
            this.llb_login.Text = "<< Have an Account? Login <<";
            // 
            // err_ID
            // 
            this.err_ID.ContainerControl = this;
            // 
            // err_fname
            // 
            this.err_fname.ContainerControl = this;
            // 
            // err_lname
            // 
            this.err_lname.ContainerControl = this;
            // 
            // err_username
            // 
            this.err_username.ContainerControl = this;
            // 
            // err_pass
            // 
            this.err_pass.ContainerControl = this;
            // 
            // HRRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(328, 515);
            this.Controls.Add(this.llb_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbx_pass);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.tbx_lname);
            this.Controls.Add(this.tbx_fname);
            this.Controls.Add(this.tbx_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HRRegister";
            this.Text = "HRRegister";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_fname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_lname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_pass)).EndInit();
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
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.TextBox tbx_fname;
        private System.Windows.Forms.TextBox tbx_lname;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.LinkLabel llb_login;
        private System.Windows.Forms.ErrorProvider err_ID;
        private System.Windows.Forms.ErrorProvider err_fname;
        private System.Windows.Forms.ErrorProvider err_lname;
        private System.Windows.Forms.ErrorProvider err_username;
        private System.Windows.Forms.ErrorProvider err_pass;
    }
}