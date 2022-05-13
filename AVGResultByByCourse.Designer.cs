
namespace WindowsFormsApp1
{
    partial class AVGResultByByCourse
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
            this.mainboard = new System.Windows.Forms.DataGridView();
            this.qLSVDBDataSet7 = new WindowsFormsApp1.QLSVDBDataSet7();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdTableAdapter = new WindowsFormsApp1.QLSVDBDataSet7TableAdapters.stdTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_tbx = new System.Windows.Forms.TextBox();
            this.find_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainboard
            // 
            this.mainboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainboard.Location = new System.Drawing.Point(371, 12);
            this.mainboard.Name = "mainboard";
            this.mainboard.Size = new System.Drawing.Size(568, 180);
            this.mainboard.TabIndex = 0;
            // 
            // qLSVDBDataSet7
            // 
            this.qLSVDBDataSet7.DataSetName = "QLSVDBDataSet7";
            this.qLSVDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.qLSVDBDataSet7;
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.stdBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(353, 150);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // ID_tbx
            // 
            this.ID_tbx.Location = new System.Drawing.Point(12, 172);
            this.ID_tbx.Name = "ID_tbx";
            this.ID_tbx.Size = new System.Drawing.Size(261, 20);
            this.ID_tbx.TabIndex = 2;
            this.ID_tbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_tbx_KeyPress);
            // 
            // find_btn
            // 
            this.find_btn.Location = new System.Drawing.Point(279, 171);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(86, 21);
            this.find_btn.TabIndex = 3;
            this.find_btn.Text = "Find ID";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // AVGResultByByCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 202);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.ID_tbx);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.mainboard);
            this.Name = "AVGResultByByCourse";
            this.Text = "AVGResultByByCourse";
            this.Load += new System.EventHandler(this.AVGResultByByCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainboard;
        private QLSVDBDataSet7 qLSVDBDataSet7;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private QLSVDBDataSet7TableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox ID_tbx;
        private System.Windows.Forms.Button find_btn;
    }
}