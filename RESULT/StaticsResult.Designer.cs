
namespace WindowsFormsApp1
{
    partial class StaticsResult
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CourseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.total_lb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.failper_lb = new System.Windows.Forms.Label();
            this.passper_lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseChart)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CourseChart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 351);
            this.panel1.TabIndex = 0;
            // 
            // CourseChart
            // 
            chartArea3.Name = "ChartArea1";
            this.CourseChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.CourseChart.Legends.Add(legend3);
            this.CourseChart.Location = new System.Drawing.Point(3, 52);
            this.CourseChart.Name = "CourseChart";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Snap ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "AVG Score";
            this.CourseChart.Series.Add(series3);
            this.CourseChart.Size = new System.Drawing.Size(656, 300);
            this.CourseChart.TabIndex = 1;
            this.CourseChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UVN Banh Mi", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statistics by Course";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.total_lb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.failper_lb);
            this.panel2.Controls.Add(this.passper_lb);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(680, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 351);
            this.panel2.TabIndex = 1;
            // 
            // total_lb
            // 
            this.total_lb.AutoSize = true;
            this.total_lb.Font = new System.Drawing.Font("UVN Banh Mi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lb.Location = new System.Drawing.Point(141, 239);
            this.total_lb.Name = "total_lb";
            this.total_lb.Size = new System.Drawing.Size(70, 38);
            this.total_lb.TabIndex = 7;
            this.total_lb.Text = "10%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UVN Banh Mi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total :";
            // 
            // failper_lb
            // 
            this.failper_lb.AutoSize = true;
            this.failper_lb.Font = new System.Drawing.Font("UVN Banh Mi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failper_lb.Location = new System.Drawing.Point(141, 169);
            this.failper_lb.Name = "failper_lb";
            this.failper_lb.Size = new System.Drawing.Size(70, 38);
            this.failper_lb.TabIndex = 5;
            this.failper_lb.Text = "10%";
            // 
            // passper_lb
            // 
            this.passper_lb.AutoSize = true;
            this.passper_lb.Font = new System.Drawing.Font("UVN Banh Mi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passper_lb.Location = new System.Drawing.Point(141, 98);
            this.passper_lb.Name = "passper_lb";
            this.passper_lb.Size = new System.Drawing.Size(70, 38);
            this.passper_lb.TabIndex = 4;
            this.passper_lb.Text = "10%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UVN Banh Mi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UVN Banh Mi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pass :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UVN Banh Mi", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Statistics by Result";
            // 
            // StaticsResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1029, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StaticsResult";
            this.Text = "StatisticsResult";
            this.Load += new System.EventHandler(this.StaticsResult_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseChart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label failper_lb;
        private System.Windows.Forms.Label passper_lb;
        private System.Windows.Forms.DataVisualization.Charting.Chart CourseChart;
        private System.Windows.Forms.Label total_lb;
        private System.Windows.Forms.Label label5;
    }
}