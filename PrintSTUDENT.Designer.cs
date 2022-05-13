
namespace WindowsFormsApp1
{
    partial class PrintSTUDENT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.female_btn = new System.Windows.Forms.RadioButton();
            this.male_btn = new System.Windows.Forms.RadioButton();
            this.all_btn = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.no_btn = new System.Windows.Forms.RadioButton();
            this.yes_btn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.savetxt_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.female_btn);
            this.panel1.Controls.Add(this.male_btn);
            this.panel1.Controls.Add(this.all_btn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 88);
            this.panel1.TabIndex = 0;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(616, 17);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(126, 52);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "CHECK";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // female_btn
            // 
            this.female_btn.AutoSize = true;
            this.female_btn.Location = new System.Drawing.Point(161, 35);
            this.female_btn.Name = "female_btn";
            this.female_btn.Size = new System.Drawing.Size(59, 17);
            this.female_btn.TabIndex = 2;
            this.female_btn.TabStop = true;
            this.female_btn.Text = "Female";
            this.female_btn.UseVisualStyleBackColor = true;
            // 
            // male_btn
            // 
            this.male_btn.AutoSize = true;
            this.male_btn.Location = new System.Drawing.Point(87, 35);
            this.male_btn.Name = "male_btn";
            this.male_btn.Size = new System.Drawing.Size(48, 17);
            this.male_btn.TabIndex = 1;
            this.male_btn.TabStop = true;
            this.male_btn.Text = "Male";
            this.male_btn.UseVisualStyleBackColor = true;
            // 
            // all_btn
            // 
            this.all_btn.AutoSize = true;
            this.all_btn.Location = new System.Drawing.Point(17, 35);
            this.all_btn.Name = "all_btn";
            this.all_btn.Size = new System.Drawing.Size(36, 17);
            this.all_btn.TabIndex = 0;
            this.all_btn.TabStop = true;
            this.all_btn.Text = "All";
            this.all_btn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.no_btn);
            this.panel3.Controls.Add(this.yes_btn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(237, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 82);
            this.panel3.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(176, 47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // no_btn
            // 
            this.no_btn.AutoSize = true;
            this.no_btn.Checked = true;
            this.no_btn.Location = new System.Drawing.Point(273, 10);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(39, 17);
            this.no_btn.TabIndex = 2;
            this.no_btn.TabStop = true;
            this.no_btn.Text = "No";
            this.no_btn.UseVisualStyleBackColor = true;
            // 
            // yes_btn
            // 
            this.yes_btn.AutoSize = true;
            this.yes_btn.Location = new System.Drawing.Point(176, 10);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(43, 17);
            this.yes_btn.TabIndex = 1;
            this.yes_btn.Text = "Yes";
            this.yes_btn.UseVisualStyleBackColor = true;
            this.yes_btn.CheckedChanged += new System.EventHandler(this.yes_btn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Date Range: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 251);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(770, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // savetxt_btn
            // 
            this.savetxt_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.savetxt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savetxt_btn.Location = new System.Drawing.Point(152, 363);
            this.savetxt_btn.Name = "savetxt_btn";
            this.savetxt_btn.Size = new System.Drawing.Size(191, 43);
            this.savetxt_btn.TabIndex = 2;
            this.savetxt_btn.Text = "Save to text";
            this.savetxt_btn.UseVisualStyleBackColor = false;
            this.savetxt_btn.Click += new System.EventHandler(this.savetxt_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.print_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.Location = new System.Drawing.Point(425, 363);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(191, 43);
            this.print_btn.TabIndex = 3;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.savetxt_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Print";
            this.Text = "Print";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton female_btn;
        private System.Windows.Forms.RadioButton male_btn;
        private System.Windows.Forms.RadioButton all_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton no_btn;
        private System.Windows.Forms.RadioButton yes_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button savetxt_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}