namespace HMS
{
    partial class DiagnosisForm
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
            this.btndochome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd_diag = new System.Windows.Forms.Button();
            this.txtdiagid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdaig_patname = new System.Windows.Forms.TextBox();
            this.txtdiag_patdisease = new System.Windows.Forms.TextBox();
            this.txtmedicine = new System.Windows.Forms.TextBox();
            this.btnupdate_diag = new System.Windows.Forms.Button();
            this.txtdiagsymptoms = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combo_pat_id = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndochome
            // 
            this.btndochome.BackColor = System.Drawing.Color.LawnGreen;
            this.btndochome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndochome.ForeColor = System.Drawing.Color.White;
            this.btndochome.Location = new System.Drawing.Point(1165, 653);
            this.btndochome.Name = "btndochome";
            this.btndochome.Size = new System.Drawing.Size(127, 75);
            this.btndochome.TabIndex = 62;
            this.btndochome.Text = "HOME";
            this.btndochome.UseVisualStyleBackColor = false;
            this.btndochome.Click += new System.EventHandler(this.btndochome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 63;
            this.label1.Text = "Diagnosis ID";
            // 
            // btnadd_diag
            // 
            this.btnadd_diag.BackColor = System.Drawing.Color.LawnGreen;
            this.btnadd_diag.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd_diag.ForeColor = System.Drawing.Color.White;
            this.btnadd_diag.Location = new System.Drawing.Point(78, 570);
            this.btnadd_diag.Name = "btnadd_diag";
            this.btnadd_diag.Size = new System.Drawing.Size(127, 75);
            this.btnadd_diag.TabIndex = 64;
            this.btnadd_diag.Text = "ADD";
            this.btnadd_diag.UseVisualStyleBackColor = false;
            this.btnadd_diag.Click += new System.EventHandler(this.btnadd_diag_Click);
            // 
            // txtdiagid
            // 
            this.txtdiagid.Location = new System.Drawing.Point(224, 255);
            this.txtdiagid.Name = "txtdiagid";
            this.txtdiagid.Size = new System.Drawing.Size(126, 22);
            this.txtdiagid.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 66;
            this.label2.Text = "Patient ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 67;
            this.label3.Text = "Patient Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 29);
            this.label4.TabIndex = 68;
            this.label4.Text = "Patient Disease";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 69;
            this.label5.Text = "Medicine";
            // 
            // txtdaig_patname
            // 
            this.txtdaig_patname.Location = new System.Drawing.Point(224, 347);
            this.txtdaig_patname.Name = "txtdaig_patname";
            this.txtdaig_patname.Size = new System.Drawing.Size(126, 22);
            this.txtdaig_patname.TabIndex = 71;
            // 
            // txtdiag_patdisease
            // 
            this.txtdiag_patdisease.Location = new System.Drawing.Point(224, 394);
            this.txtdiag_patdisease.Name = "txtdiag_patdisease";
            this.txtdiag_patdisease.Size = new System.Drawing.Size(126, 22);
            this.txtdiag_patdisease.TabIndex = 72;
            // 
            // txtmedicine
            // 
            this.txtmedicine.Location = new System.Drawing.Point(224, 432);
            this.txtmedicine.Name = "txtmedicine";
            this.txtmedicine.Size = new System.Drawing.Size(126, 22);
            this.txtmedicine.TabIndex = 73;
            // 
            // btnupdate_diag
            // 
            this.btnupdate_diag.BackColor = System.Drawing.Color.LawnGreen;
            this.btnupdate_diag.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate_diag.ForeColor = System.Drawing.Color.White;
            this.btnupdate_diag.Location = new System.Drawing.Point(253, 570);
            this.btnupdate_diag.Name = "btnupdate_diag";
            this.btnupdate_diag.Size = new System.Drawing.Size(127, 75);
            this.btnupdate_diag.TabIndex = 75;
            this.btnupdate_diag.Text = "UPDATE";
            this.btnupdate_diag.UseVisualStyleBackColor = false;
            this.btnupdate_diag.Click += new System.EventHandler(this.btnupdate_diag_Click);
            // 
            // txtdiagsymptoms
            // 
            this.txtdiagsymptoms.Location = new System.Drawing.Point(224, 485);
            this.txtdiagsymptoms.Name = "txtdiagsymptoms";
            this.txtdiagsymptoms.Size = new System.Drawing.Size(126, 22);
            this.txtdiagsymptoms.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 29);
            this.label6.TabIndex = 76;
            this.label6.Text = "Symptoms";
            // 
            // combo_pat_id
            // 
            this.combo_pat_id.FormattingEnabled = true;
            this.combo_pat_id.Location = new System.Drawing.Point(224, 299);
            this.combo_pat_id.Name = "combo_pat_id";
            this.combo_pat_id.Size = new System.Drawing.Size(126, 24);
            this.combo_pat_id.TabIndex = 78;
            this.combo_pat_id.SelectedIndexChanged += new System.EventHandler(this.combo_pat_id_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 252);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LawnGreen;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(171, 669);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(127, 75);
            this.btndelete.TabIndex = 80;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MediumBlue;
            this.label15.Location = new System.Drawing.Point(0, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(827, 69);
            this.label15.TabIndex = 81;
            this.label15.Text = "Hospital Management System";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Location = new System.Drawing.Point(34, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 38);
            this.label7.TabIndex = 82;
            this.label7.Text = "Diagnosis Form";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumBlue;
            this.label12.Location = new System.Drawing.Point(433, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 38);
            this.label12.TabIndex = 83;
            this.label12.Text = "Patient List";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1337, 756);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.combo_pat_id);
            this.Controls.Add(this.txtdiagsymptoms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnupdate_diag);
            this.Controls.Add(this.txtmedicine);
            this.Controls.Add(this.txtdiag_patdisease);
            this.Controls.Add(this.txtdaig_patname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdiagid);
            this.Controls.Add(this.btnadd_diag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndochome);
            this.Name = "DiagnosisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosisForm";
            this.Load += new System.EventHandler(this.DiagnosisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndochome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd_diag;
        private System.Windows.Forms.TextBox txtdiagid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdaig_patname;
        private System.Windows.Forms.TextBox txtdiag_patdisease;
        private System.Windows.Forms.TextBox txtmedicine;
        private System.Windows.Forms.Button btnupdate_diag;
        private System.Windows.Forms.TextBox txtdiagsymptoms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combo_pat_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
    }
}