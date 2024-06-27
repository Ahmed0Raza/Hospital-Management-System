namespace HMS
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtexp = new System.Windows.Forms.TextBox();
            this.btnadd_doc = new System.Windows.Forms.Button();
            this.btnupdate_doc = new System.Windows.Forms.Button();
            this.btndelete_doc = new System.Windows.Forms.Button();
            this.txtdocage = new System.Windows.Forms.TextBox();
            this.combodocbloodgroup = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.combodocgender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdocaddress = new System.Windows.Forms.TextBox();
            this.txtdocphone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pbox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ebox = new System.Windows.Forms.TextBox();
            this.non = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backbtnnn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cnicbox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.specializationbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(43, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(43, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(43, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Salary";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(323, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Experience";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(148, 114);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(169, 22);
            this.txtid.TabIndex = 5;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(148, 142);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(169, 22);
            this.txtname.TabIndex = 6;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(148, 170);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(169, 22);
            this.txtsalary.TabIndex = 7;
            this.txtsalary.TextChanged += new System.EventHandler(this.txtsalary_TextChanged);
            // 
            // txtexp
            // 
            this.txtexp.Location = new System.Drawing.Point(458, 116);
            this.txtexp.Name = "txtexp";
            this.txtexp.Size = new System.Drawing.Size(169, 22);
            this.txtexp.TabIndex = 8;
            this.txtexp.TextChanged += new System.EventHandler(this.txtexp_TextChanged);
            // 
            // btnadd_doc
            // 
            this.btnadd_doc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnadd_doc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadd_doc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd_doc.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd_doc.ForeColor = System.Drawing.Color.White;
            this.btnadd_doc.Location = new System.Drawing.Point(44, 335);
            this.btnadd_doc.Name = "btnadd_doc";
            this.btnadd_doc.Size = new System.Drawing.Size(90, 44);
            this.btnadd_doc.TabIndex = 9;
            this.btnadd_doc.Text = "ADD";
            this.btnadd_doc.UseVisualStyleBackColor = false;
            this.btnadd_doc.Click += new System.EventHandler(this.btnadd_doc_Click);
            // 
            // btnupdate_doc
            // 
            this.btnupdate_doc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnupdate_doc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupdate_doc.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate_doc.ForeColor = System.Drawing.Color.White;
            this.btnupdate_doc.Location = new System.Drawing.Point(259, 335);
            this.btnupdate_doc.Name = "btnupdate_doc";
            this.btnupdate_doc.Size = new System.Drawing.Size(90, 44);
            this.btnupdate_doc.TabIndex = 10;
            this.btnupdate_doc.Text = "UPDATE";
            this.btnupdate_doc.UseVisualStyleBackColor = false;
            this.btnupdate_doc.Click += new System.EventHandler(this.btnupdate_doc_Click);
            // 
            // btndelete_doc
            // 
            this.btndelete_doc.BackColor = System.Drawing.Color.SteelBlue;
            this.btndelete_doc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete_doc.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete_doc.ForeColor = System.Drawing.Color.White;
            this.btndelete_doc.Location = new System.Drawing.Point(148, 335);
            this.btndelete_doc.Name = "btndelete_doc";
            this.btndelete_doc.Size = new System.Drawing.Size(90, 44);
            this.btndelete_doc.TabIndex = 11;
            this.btndelete_doc.Text = "DELETE";
            this.btndelete_doc.UseVisualStyleBackColor = false;
            this.btndelete_doc.Click += new System.EventHandler(this.btndelete_doc_Click);
            // 
            // txtdocage
            // 
            this.txtdocage.Location = new System.Drawing.Point(148, 255);
            this.txtdocage.Name = "txtdocage";
            this.txtdocage.Size = new System.Drawing.Size(169, 22);
            this.txtdocage.TabIndex = 59;
            this.txtdocage.TextChanged += new System.EventHandler(this.txtdocage_TextChanged);
            // 
            // combodocbloodgroup
            // 
            this.combodocbloodgroup.FormattingEnabled = true;
            this.combodocbloodgroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+"});
            this.combodocbloodgroup.Location = new System.Drawing.Point(458, 230);
            this.combodocbloodgroup.Name = "combodocbloodgroup";
            this.combodocbloodgroup.Size = new System.Drawing.Size(169, 24);
            this.combodocbloodgroup.TabIndex = 58;
            this.combodocbloodgroup.SelectedIndexChanged += new System.EventHandler(this.combodocbloodgroup_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(323, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 22);
            this.label11.TabIndex = 57;
            this.label11.Text = "Blood Group";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // combodocgender
            // 
            this.combodocgender.FormattingEnabled = true;
            this.combodocgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.combodocgender.Location = new System.Drawing.Point(458, 200);
            this.combodocgender.Name = "combodocgender";
            this.combodocgender.Size = new System.Drawing.Size(169, 24);
            this.combodocgender.TabIndex = 56;
            this.combodocgender.SelectedIndexChanged += new System.EventHandler(this.combodocgender_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(323, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 22);
            this.label10.TabIndex = 55;
            this.label10.Text = "Gender";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(7, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(43, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 22);
            this.label12.TabIndex = 53;
            this.label12.Text = "Age";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtdocaddress
            // 
            this.txtdocaddress.Location = new System.Drawing.Point(148, 226);
            this.txtdocaddress.Name = "txtdocaddress";
            this.txtdocaddress.Size = new System.Drawing.Size(169, 22);
            this.txtdocaddress.TabIndex = 52;
            this.txtdocaddress.TextChanged += new System.EventHandler(this.txtdocaddress_TextChanged);
            // 
            // txtdocphone
            // 
            this.txtdocphone.Location = new System.Drawing.Point(148, 198);
            this.txtdocphone.Name = "txtdocphone";
            this.txtdocphone.Size = new System.Drawing.Size(169, 22);
            this.txtdocphone.TabIndex = 51;
            this.txtdocphone.TextChanged += new System.EventHandler(this.txtdocphone_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(43, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 22);
            this.label13.TabIndex = 50;
            this.label13.Text = "Address";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(43, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 22);
            this.label14.TabIndex = 60;
            this.label14.Text = "Phone";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // pbox
            // 
            this.pbox.Location = new System.Drawing.Point(459, 172);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(169, 22);
            this.pbox.TabIndex = 92;
            this.pbox.TextChanged += new System.EventHandler(this.pbox_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(323, 172);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 22);
            this.label18.TabIndex = 91;
            this.label18.Text = "Password";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // ebox
            // 
            this.ebox.Location = new System.Drawing.Point(458, 144);
            this.ebox.Name = "ebox";
            this.ebox.Size = new System.Drawing.Size(169, 22);
            this.ebox.TabIndex = 90;
            this.ebox.TextChanged += new System.EventHandler(this.ebox_TextChanged);
            // 
            // non
            // 
            this.non.AutoSize = true;
            this.non.BackColor = System.Drawing.Color.Transparent;
            this.non.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.non.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.non.Location = new System.Drawing.Point(324, 142);
            this.non.Name = "non";
            this.non.Size = new System.Drawing.Size(59, 22);
            this.non.TabIndex = 89;
            this.non.Text = "Email";
            this.non.Click += new System.EventHandler(this.non_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(36, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(537, 44);
            this.label15.TabIndex = 93;
            this.label15.Text = "Hospital Management System";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 440);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(11, 10);
            this.dataGridView1.TabIndex = 94;
            // 
            // backbtnnn
            // 
            this.backbtnnn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backbtnnn.BackColor = System.Drawing.Color.SteelBlue;
            this.backbtnnn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backbtnnn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.backbtnnn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbtnnn.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtnnn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backbtnnn.Location = new System.Drawing.Point(772, 394);
            this.backbtnnn.Name = "backbtnnn";
            this.backbtnnn.Size = new System.Drawing.Size(90, 44);
            this.backbtnnn.TabIndex = 95;
            this.backbtnnn.Text = "Home";
            this.backbtnnn.UseVisualStyleBackColor = false;
            this.backbtnnn.Click += new System.EventHandler(this.backbtnnn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(324, 255);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 22);
            this.label16.TabIndex = 96;
            this.label16.Text = "CNIC";
            // 
            // cnicbox
            // 
            this.cnicbox.Location = new System.Drawing.Point(459, 260);
            this.cnicbox.Name = "cnicbox";
            this.cnicbox.Size = new System.Drawing.Size(168, 22);
            this.cnicbox.TabIndex = 97;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(8, 281);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 22);
            this.label17.TabIndex = 98;
            this.label17.Text = "Specialization";
            // 
            // specializationbox
            // 
            this.specializationbox.Location = new System.Drawing.Point(148, 283);
            this.specializationbox.Name = "specializationbox";
            this.specializationbox.Size = new System.Drawing.Size(169, 22);
            this.specializationbox.TabIndex = 99;
            this.specializationbox.TextChanged += new System.EventHandler(this.specializationbox_TextChanged);
            // 
            // DoctorForm
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.specializationbox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cnicbox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.backbtnnn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ebox);
            this.Controls.Add(this.non);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtdocage);
            this.Controls.Add(this.combodocbloodgroup);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.combodocgender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtdocaddress);
            this.Controls.Add(this.txtdocphone);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btndelete_doc);
            this.Controls.Add(this.btnupdate_doc);
            this.Controls.Add(this.btnadd_doc);
            this.Controls.Add(this.txtexp);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnadd;
        private System.Windows.Forms.TextBox txtdocID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtdocNAME;
        private System.Windows.Forms.TextBox txtdocSALRY;
        private System.Windows.Forms.TextBox txtdocEXP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtexp;
        private System.Windows.Forms.Button btnadd_doc;
        private System.Windows.Forms.Button btnupdate_doc;
        private System.Windows.Forms.Button btndelete_doc;
        private System.Windows.Forms.TextBox txtdocage;
        private System.Windows.Forms.ComboBox combodocbloodgroup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combodocgender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdocaddress;
        private System.Windows.Forms.TextBox txtdocphone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox pbox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ebox;
        private System.Windows.Forms.Label non;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backbtnnn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox cnicbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox specializationbox;
    }
}