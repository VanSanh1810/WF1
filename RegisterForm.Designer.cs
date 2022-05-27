
namespace WindowsFormsApp1
{
    partial class RegisterForm
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
            this.signup_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usern_tbx = new System.Windows.Forms.TextBox();
            this.pssw_tbx = new System.Windows.Forms.TextBox();
            this.rpssw_tbx = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lklb_goback = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.signup_btn.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.Location = new System.Drawing.Point(44, 241);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(104, 43);
            this.signup_btn.TabIndex = 0;
            this.signup_btn.Text = "Sign up";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancel_btn.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(170, 241);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(100, 43);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UTM Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re-enter Password";
            // 
            // usern_tbx
            // 
            this.usern_tbx.Location = new System.Drawing.Point(149, 99);
            this.usern_tbx.Name = "usern_tbx";
            this.usern_tbx.Size = new System.Drawing.Size(148, 20);
            this.usern_tbx.TabIndex = 5;
            this.usern_tbx.Leave += new System.EventHandler(this.usern_tbx_Leave);
            // 
            // pssw_tbx
            // 
            this.pssw_tbx.Location = new System.Drawing.Point(149, 139);
            this.pssw_tbx.Name = "pssw_tbx";
            this.pssw_tbx.PasswordChar = '*';
            this.pssw_tbx.Size = new System.Drawing.Size(148, 20);
            this.pssw_tbx.TabIndex = 6;
            // 
            // rpssw_tbx
            // 
            this.rpssw_tbx.Location = new System.Drawing.Point(149, 178);
            this.rpssw_tbx.Name = "rpssw_tbx";
            this.rpssw_tbx.PasswordChar = '*';
            this.rpssw_tbx.Size = new System.Drawing.Size(148, 20);
            this.rpssw_tbx.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lklb_goback
            // 
            this.lklb_goback.AutoSize = true;
            this.lklb_goback.Location = new System.Drawing.Point(89, 300);
            this.lklb_goback.Name = "lklb_goback";
            this.lklb_goback.Size = new System.Drawing.Size(140, 13);
            this.lklb_goback.TabIndex = 8;
            this.lklb_goback.TabStop = true;
            this.lklb_goback.Text = "<< Have an accout ? Login ";
            this.lklb_goback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklb_goback_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UVN Banh Mi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "REGISTER";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(312, 317);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lklb_goback);
            this.Controls.Add(this.rpssw_tbx);
            this.Controls.Add(this.pssw_tbx);
            this.Controls.Add(this.usern_tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.signup_btn);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usern_tbx;
        private System.Windows.Forms.TextBox pssw_tbx;
        private System.Windows.Forms.TextBox rpssw_tbx;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel lklb_goback;
        private System.Windows.Forms.Label label4;
    }
}