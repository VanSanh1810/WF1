
namespace WindowsFormsApp1
{
    partial class HRForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llb_logout = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.llb_refresh = new System.Windows.Forms.LinkLabel();
            this.llb_editpro = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.myGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDBDataSet14 = new WindowsFormsApp1.QLSVDBDataSet14();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_editgroup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_EditGRName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_removegroup = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_addgroup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_addGRName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_showfullcontact = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_selectcontactID = new System.Windows.Forms.Button();
            this.btn_removecontact = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_editcontact = new System.Windows.Forms.Button();
            this.btn_addcontact = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.myGroupTableAdapter = new WindowsFormsApp1.QLSVDBDataSet14TableAdapters.myGroupTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet14)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Azuki", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(82, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.llb_logout);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.llb_refresh);
            this.panel1.Controls.Add(this.llb_editpro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 78);
            this.panel1.TabIndex = 2;
            // 
            // llb_logout
            // 
            this.llb_logout.AutoSize = true;
            this.llb_logout.Font = new System.Drawing.Font("ahkio", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_logout.Location = new System.Drawing.Point(277, 44);
            this.llb_logout.Name = "llb_logout";
            this.llb_logout.Size = new System.Drawing.Size(52, 20);
            this.llb_logout.TabIndex = 7;
            this.llb_logout.TabStop = true;
            this.llb_logout.Text = "Log out";
            this.llb_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_logout_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("ahkio", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(256, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "||";
            // 
            // llb_refresh
            // 
            this.llb_refresh.AutoSize = true;
            this.llb_refresh.Font = new System.Drawing.Font("ahkio", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_refresh.Location = new System.Drawing.Point(198, 44);
            this.llb_refresh.Name = "llb_refresh";
            this.llb_refresh.Size = new System.Drawing.Size(52, 20);
            this.llb_refresh.TabIndex = 5;
            this.llb_refresh.TabStop = true;
            this.llb_refresh.Text = "Refresh";
            this.llb_refresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_refresh_LinkClicked);
            // 
            // llb_editpro
            // 
            this.llb_editpro.AutoSize = true;
            this.llb_editpro.Font = new System.Drawing.Font("ahkio", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_editpro.Location = new System.Drawing.Point(81, 44);
            this.llb_editpro.Name = "llb_editpro";
            this.llb_editpro.Size = new System.Drawing.Size(90, 20);
            this.llb_editpro.TabIndex = 4;
            this.llb_editpro.TabStop = true;
            this.llb_editpro.Text = "Edit my Profile";
            this.llb_editpro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_editpro_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ahkio", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "||";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("UTM Azuki", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_username.Location = new System.Drawing.Point(171, 12);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(79, 23);
            this.lb_username.TabIndex = 2;
            this.lb_username.Text = "Welcome";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 407);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(404, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 401);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel7.Controls.Add(this.comboBox1);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.btn_editgroup);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.tbx_EditGRName);
            this.panel7.Location = new System.Drawing.Point(3, 172);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(389, 136);
            this.panel7.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.myGroupBindingSource;
            this.comboBox1.DisplayMember = "Gr_name";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(187, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "id";
            // 
            // myGroupBindingSource
            // 
            this.myGroupBindingSource.DataMember = "myGroup";
            this.myGroupBindingSource.DataSource = this.qLSVDBDataSet14;
            // 
            // qLSVDBDataSet14
            // 
            this.qLSVDBDataSet14.DataSetName = "QLSVDBDataSet14";
            this.qLSVDBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "SELECT GROUP";
            // 
            // btn_editgroup
            // 
            this.btn_editgroup.BackColor = System.Drawing.Color.Aqua;
            this.btn_editgroup.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editgroup.Location = new System.Drawing.Point(187, 96);
            this.btn_editgroup.Name = "btn_editgroup";
            this.btn_editgroup.Size = new System.Drawing.Size(124, 34);
            this.btn_editgroup.TabIndex = 5;
            this.btn_editgroup.Text = "EDIT";
            this.btn_editgroup.UseVisualStyleBackColor = false;
            this.btn_editgroup.Click += new System.EventHandler(this.btn_editgroup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "ENTER NEW NAME";
            // 
            // tbx_EditGRName
            // 
            this.tbx_EditGRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_EditGRName.Location = new System.Drawing.Point(187, 64);
            this.tbx_EditGRName.Name = "tbx_EditGRName";
            this.tbx_EditGRName.Size = new System.Drawing.Size(187, 26);
            this.tbx_EditGRName.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel6.Controls.Add(this.comboBox2);
            this.panel6.Controls.Add(this.btn_removegroup);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(3, 314);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(389, 84);
            this.panel6.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.myGroupBindingSource;
            this.comboBox2.DisplayMember = "Gr_name";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(187, 11);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(187, 28);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "id";
            // 
            // btn_removegroup
            // 
            this.btn_removegroup.BackColor = System.Drawing.Color.Red;
            this.btn_removegroup.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removegroup.Location = new System.Drawing.Point(187, 43);
            this.btn_removegroup.Name = "btn_removegroup";
            this.btn_removegroup.Size = new System.Drawing.Size(124, 34);
            this.btn_removegroup.TabIndex = 5;
            this.btn_removegroup.Text = "REMOVE";
            this.btn_removegroup.UseVisualStyleBackColor = false;
            this.btn_removegroup.Click += new System.EventHandler(this.btn_removegroup_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "ENTER GROUP NAME";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel5.Controls.Add(this.btn_addgroup);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.tbx_addGRName);
            this.panel5.Location = new System.Drawing.Point(3, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(389, 84);
            this.panel5.TabIndex = 2;
            // 
            // btn_addgroup
            // 
            this.btn_addgroup.BackColor = System.Drawing.Color.Lime;
            this.btn_addgroup.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addgroup.Location = new System.Drawing.Point(187, 44);
            this.btn_addgroup.Name = "btn_addgroup";
            this.btn_addgroup.Size = new System.Drawing.Size(124, 34);
            this.btn_addgroup.TabIndex = 2;
            this.btn_addgroup.Text = "ADD";
            this.btn_addgroup.UseVisualStyleBackColor = false;
            this.btn_addgroup.Click += new System.EventHandler(this.btn_addgroup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "ENTER GROUP NAME";
            // 
            // tbx_addGRName
            // 
            this.tbx_addGRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_addGRName.Location = new System.Drawing.Point(187, 12);
            this.tbx_addGRName.Name = "tbx_addGRName";
            this.tbx_addGRName.Size = new System.Drawing.Size(187, 26);
            this.tbx_addGRName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Group";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btn_showfullcontact);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.btn_editcontact);
            this.panel3.Controls.Add(this.btn_addcontact);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 401);
            this.panel3.TabIndex = 0;
            // 
            // btn_showfullcontact
            // 
            this.btn_showfullcontact.BackColor = System.Drawing.Color.Aqua;
            this.btn_showfullcontact.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showfullcontact.Location = new System.Drawing.Point(3, 314);
            this.btn_showfullcontact.Name = "btn_showfullcontact";
            this.btn_showfullcontact.Size = new System.Drawing.Size(389, 34);
            this.btn_showfullcontact.TabIndex = 10;
            this.btn_showfullcontact.Text = "SHOW FULL LIST";
            this.btn_showfullcontact.UseVisualStyleBackColor = false;
            this.btn_showfullcontact.Click += new System.EventHandler(this.btn_showfullcontact_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel8.Controls.Add(this.btn_selectcontactID);
            this.panel8.Controls.Add(this.btn_removecontact);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.textBox4);
            this.panel8.Location = new System.Drawing.Point(3, 181);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(389, 84);
            this.panel8.TabIndex = 3;
            // 
            // btn_selectcontactID
            // 
            this.btn_selectcontactID.BackColor = System.Drawing.Color.Yellow;
            this.btn_selectcontactID.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectcontactID.Location = new System.Drawing.Point(312, 9);
            this.btn_selectcontactID.Name = "btn_selectcontactID";
            this.btn_selectcontactID.Size = new System.Drawing.Size(74, 34);
            this.btn_selectcontactID.TabIndex = 3;
            this.btn_selectcontactID.Text = "SELECT";
            this.btn_selectcontactID.UseVisualStyleBackColor = false;
            this.btn_selectcontactID.Click += new System.EventHandler(this.btn_selectcontactID_Click);
            // 
            // btn_removecontact
            // 
            this.btn_removecontact.BackColor = System.Drawing.Color.Red;
            this.btn_removecontact.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removecontact.Location = new System.Drawing.Point(79, 44);
            this.btn_removecontact.Name = "btn_removecontact";
            this.btn_removecontact.Size = new System.Drawing.Size(227, 34);
            this.btn_removecontact.TabIndex = 2;
            this.btn_removecontact.Text = "REMOVE";
            this.btn_removecontact.UseVisualStyleBackColor = false;
            this.btn_removecontact.Click += new System.EventHandler(this.btn_removecontact_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "ENTER CONTACT ID";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(169, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 26);
            this.textBox4.TabIndex = 0;
            // 
            // btn_editcontact
            // 
            this.btn_editcontact.BackColor = System.Drawing.Color.Aqua;
            this.btn_editcontact.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editcontact.Location = new System.Drawing.Point(21, 132);
            this.btn_editcontact.Name = "btn_editcontact";
            this.btn_editcontact.Size = new System.Drawing.Size(124, 34);
            this.btn_editcontact.TabIndex = 9;
            this.btn_editcontact.Text = "EDIT";
            this.btn_editcontact.UseVisualStyleBackColor = false;
            this.btn_editcontact.Click += new System.EventHandler(this.btn_editcontact_Click);
            // 
            // btn_addcontact
            // 
            this.btn_addcontact.BackColor = System.Drawing.Color.Lime;
            this.btn_addcontact.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcontact.Location = new System.Drawing.Point(21, 90);
            this.btn_addcontact.Name = "btn_addcontact";
            this.btn_addcontact.Size = new System.Drawing.Size(124, 34);
            this.btn_addcontact.TabIndex = 3;
            this.btn_addcontact.Text = "ADD";
            this.btn_addcontact.UseVisualStyleBackColor = false;
            this.btn_addcontact.Click += new System.EventHandler(this.btn_addcontact_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contact";
            // 
            // myGroupTableAdapter
            // 
            this.myGroupTableAdapter.ClearBeforeFill = true;
            // 
            // HRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(825, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HRForm";
            this.Text = "HR";
            this.Load += new System.EventHandler(this.HRForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet14)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llb_refresh;
        private System.Windows.Forms.LinkLabel llb_editpro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addgroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_addGRName;
        private System.Windows.Forms.Button btn_editgroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_EditGRName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_removegroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_editcontact;
        private System.Windows.Forms.Button btn_addcontact;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_removecontact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_selectcontactID;
        private System.Windows.Forms.Button btn_showfullcontact;
        private QLSVDBDataSet14 qLSVDBDataSet14;
        private System.Windows.Forms.BindingSource myGroupBindingSource;
        private QLSVDBDataSet14TableAdapters.myGroupTableAdapter myGroupTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.LinkLabel llb_logout;
        private System.Windows.Forms.Label label10;
    }
}