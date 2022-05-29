
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
            this.courseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDBDataSet13 = new WindowsFormsApp1.QLSVDBDataSet13();
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
            this.courseTableAdapter2 = new WindowsFormsApp1.QLSVDBDataSet13TableAdapters.CourseTableAdapter();
            this.btn_shstu = new System.Windows.Forms.Button();
            this.btn_shsco = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet13)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("ahkio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ahkio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Course :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ahkio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Score :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ahkio", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description :";
            // 
            // stuID_tbx
            // 
            this.stuID_tbx.Location = new System.Drawing.Point(131, 33);
            this.stuID_tbx.Name = "stuID_tbx";
            this.stuID_tbx.Size = new System.Drawing.Size(163, 20);
            this.stuID_tbx.TabIndex = 4;
            this.stuID_tbx.Leave += new System.EventHandler(this.stuID_tbx_Leave);
            // 
            // score_tbx
            // 
            this.score_tbx.Location = new System.Drawing.Point(132, 133);
            this.score_tbx.Name = "score_tbx";
            this.score_tbx.Size = new System.Drawing.Size(163, 20);
            this.score_tbx.TabIndex = 5;
            this.score_tbx.Leave += new System.EventHandler(this.score_tbx_Leave);
            // 
            // desc__tbx
            // 
            this.desc__tbx.Location = new System.Drawing.Point(131, 185);
            this.desc__tbx.Multiline = true;
            this.desc__tbx.Name = "desc__tbx";
            this.desc__tbx.Size = new System.Drawing.Size(163, 91);
            this.desc__tbx.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.courseBindingSource2;
            this.comboBox1.DisplayMember = "label";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // courseBindingSource2
            // 
            this.courseBindingSource2.DataMember = "Course";
            this.courseBindingSource2.DataSource = this.qLSVDBDataSet13;
            // 
            // qLSVDBDataSet13
            // 
            this.qLSVDBDataSet13.DataSetName = "QLSVDBDataSet13";
            this.qLSVDBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.button1.Location = new System.Drawing.Point(12, 325);
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
            this.add_btn.BackColor = System.Drawing.Color.Lime;
            this.add_btn.Font = new System.Drawing.Font("VNI-Jamai", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(301, 291);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(134, 57);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(301, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 212);
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
            this.refresh_btn.Location = new System.Drawing.Point(838, 287);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(85, 30);
            this.refresh_btn.TabIndex = 11;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.Fuchsia;
            this.edit_btn.Font = new System.Drawing.Font("VNI-Jamai", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(441, 291);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(134, 57);
            this.edit_btn.TabIndex = 12;
            this.edit_btn.Text = "EDIT";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.del_btn.Font = new System.Drawing.Font("VNI-Jamai", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(581, 291);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(134, 57);
            this.del_btn.TabIndex = 13;
            this.del_btn.Text = "DELETE";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // avgscore_btn
            // 
            this.avgscore_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.avgscore_btn.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgscore_btn.Location = new System.Drawing.Point(233, 77);
            this.avgscore_btn.Name = "avgscore_btn";
            this.avgscore_btn.Size = new System.Drawing.Size(61, 23);
            this.avgscore_btn.TabIndex = 14;
            this.avgscore_btn.Text = "AVG ";
            this.avgscore_btn.UseVisualStyleBackColor = false;
            this.avgscore_btn.Click += new System.EventHandler(this.avgscore_btn_Click);
            // 
            // courseTableAdapter2
            // 
            this.courseTableAdapter2.ClearBeforeFill = true;
            // 
            // btn_shstu
            // 
            this.btn_shstu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_shstu.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shstu.Location = new System.Drawing.Point(301, 33);
            this.btn_shstu.Name = "btn_shstu";
            this.btn_shstu.Size = new System.Drawing.Size(305, 24);
            this.btn_shstu.TabIndex = 15;
            this.btn_shstu.Text = "Show student";
            this.btn_shstu.UseVisualStyleBackColor = false;
            this.btn_shstu.Click += new System.EventHandler(this.btn_shstu_Click);
            // 
            // btn_shsco
            // 
            this.btn_shsco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_shsco.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shsco.Location = new System.Drawing.Point(612, 33);
            this.btn_shsco.Name = "btn_shsco";
            this.btn_shsco.Size = new System.Drawing.Size(312, 25);
            this.btn_shsco.TabIndex = 16;
            this.btn_shsco.Text = "Show score";
            this.btn_shsco.UseVisualStyleBackColor = false;
            this.btn_shsco.Click += new System.EventHandler(this.btn_shsco_Click);
            // 
            // AddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(935, 360);
            this.Controls.Add(this.btn_shsco);
            this.Controls.Add(this.btn_shstu);
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
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet13)).EndInit();
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
        private QLSVDBDataSet13 qLSVDBDataSet13;
        private System.Windows.Forms.BindingSource courseBindingSource2;
        private QLSVDBDataSet13TableAdapters.CourseTableAdapter courseTableAdapter2;
        private System.Windows.Forms.Button btn_shsco;
        private System.Windows.Forms.Button btn_shstu;
    }
}