
namespace WindowsFormsApp1
{
    partial class AddScore
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
            this.stuID_tbx = new System.Windows.Forms.TextBox();
            this.score_tbx = new System.Windows.Forms.TextBox();
            this.desc__tbx = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDBDataSet3 = new WindowsFormsApp1.QLSVDBDataSet3();
            this.qLSVDBDataSet2 = new WindowsFormsApp1.QLSVDBDataSet2();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new WindowsFormsApp1.QLSVDBDataSet2TableAdapters.CourseTableAdapter();
            this.courseTableAdapter1 = new WindowsFormsApp1.QLSVDBDataSet3TableAdapters.CourseTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.err_IDstu = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_score = new System.Windows.Forms.ErrorProvider(this.components);
            this.refresh_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.avgscore_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_IDstu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_score)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Course :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description :";
            // 
            // stuID_tbx
            // 
            this.stuID_tbx.Location = new System.Drawing.Point(110, 33);
            this.stuID_tbx.Name = "stuID_tbx";
            this.stuID_tbx.Size = new System.Drawing.Size(163, 20);
            this.stuID_tbx.TabIndex = 4;
            this.stuID_tbx.Leave += new System.EventHandler(this.stuID_tbx_Leave);
            // 
            // score_tbx
            // 
            this.score_tbx.Location = new System.Drawing.Point(110, 132);
            this.score_tbx.Name = "score_tbx";
            this.score_tbx.Size = new System.Drawing.Size(163, 20);
            this.score_tbx.TabIndex = 5;
            this.score_tbx.Leave += new System.EventHandler(this.score_tbx_Leave);
            // 
            // desc__tbx
            // 
            this.desc__tbx.Location = new System.Drawing.Point(110, 185);
            this.desc__tbx.Multiline = true;
            this.desc__tbx.Name = "desc__tbx";
            this.desc__tbx.Size = new System.Drawing.Size(163, 91);
            this.desc__tbx.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.courseBindingSource1;
            this.comboBox1.DisplayMember = "label";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.qLSVDBDataSet3;
            // 
            // qLSVDBDataSet3
            // 
            this.qLSVDBDataSet3.DataSetName = "QLSVDBDataSet3";
            this.qLSVDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLSVDBDataSet2
            // 
            this.qLSVDBDataSet2.DataSetName = "QLSVDBDataSet2";
            this.qLSVDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.qLSVDBDataSet2;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(110, 291);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 57);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(227, 262);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // err_IDstu
            // 
            this.err_IDstu.ContainerControl = this;
            // 
            // err_score
            // 
            this.err_score.ContainerControl = this;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(462, 291);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(85, 30);
            this.refresh_btn.TabIndex = 11;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(198, 291);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 57);
            this.edit_btn.TabIndex = 12;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(279, 291);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 57);
            this.del_btn.TabIndex = 13;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // avgscore_btn
            // 
            this.avgscore_btn.Location = new System.Drawing.Point(212, 77);
            this.avgscore_btn.Name = "avgscore_btn";
            this.avgscore_btn.Size = new System.Drawing.Size(61, 23);
            this.avgscore_btn.TabIndex = 14;
            this.avgscore_btn.Text = "AVG ";
            this.avgscore_btn.UseVisualStyleBackColor = true;
            this.avgscore_btn.Click += new System.EventHandler(this.avgscore_btn_Click);
            // 
            // AddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 360);
            this.Controls.Add(this.avgscore_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.desc__tbx);
            this.Controls.Add(this.score_tbx);
            this.Controls.Add(this.stuID_tbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddScore";
            this.Text = "AddScore";
            this.Load += new System.EventHandler(this.AddScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_IDstu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stuID_tbx;
        private System.Windows.Forms.TextBox score_tbx;
        private System.Windows.Forms.TextBox desc__tbx;
        private System.Windows.Forms.ComboBox comboBox1;
        private QLSVDBDataSet2 qLSVDBDataSet2;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private QLSVDBDataSet2TableAdapters.CourseTableAdapter courseTableAdapter;
        private QLSVDBDataSet3 qLSVDBDataSet3;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private QLSVDBDataSet3TableAdapters.CourseTableAdapter courseTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider err_IDstu;
        private System.Windows.Forms.ErrorProvider err_score;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button avgscore_btn;
    }
}