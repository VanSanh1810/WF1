
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // signup_btn
            // 
            this.signup_btn.Location = new System.Drawing.Point(40, 176);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(104, 43);
            this.signup_btn.TabIndex = 0;
            this.signup_btn.Text = "Sign up";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(166, 176);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(100, 43);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re-enter Password";
            // 
            // usern_tbx
            // 
            this.usern_tbx.Location = new System.Drawing.Point(115, 34);
            this.usern_tbx.Name = "usern_tbx";
            this.usern_tbx.Size = new System.Drawing.Size(178, 20);
            this.usern_tbx.TabIndex = 5;
            this.usern_tbx.Leave += new System.EventHandler(this.usern_tbx_Leave);
            // 
            // pssw_tbx
            // 
            this.pssw_tbx.Location = new System.Drawing.Point(115, 74);
            this.pssw_tbx.Name = "pssw_tbx";
            this.pssw_tbx.PasswordChar = '*';
            this.pssw_tbx.Size = new System.Drawing.Size(178, 20);
            this.pssw_tbx.TabIndex = 6;
            // 
            // rpssw_tbx
            // 
            this.rpssw_tbx.Location = new System.Drawing.Point(115, 113);
            this.rpssw_tbx.Name = "rpssw_tbx";
            this.rpssw_tbx.PasswordChar = '*';
            this.rpssw_tbx.Size = new System.Drawing.Size(178, 20);
            this.rpssw_tbx.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(312, 257);
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
    }
}