namespace HMS
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.logutbtn = new System.Windows.Forms.Button();
            this.AddDoc = new System.Windows.Forms.Button();
            this.AddPat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PatientList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 44);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hospital Management System";
            // 
            // logutbtn
            // 
            this.logutbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.logutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logutbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.logutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logutbtn.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logutbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logutbtn.Location = new System.Drawing.Point(743, 381);
            this.logutbtn.Name = "logutbtn";
            this.logutbtn.Size = new System.Drawing.Size(90, 44);
            this.logutbtn.TabIndex = 22;
            this.logutbtn.Text = "Logout";
            this.logutbtn.UseVisualStyleBackColor = false;
            this.logutbtn.Click += new System.EventHandler(this.logutbtn_Click);
            // 
            // AddDoc
            // 
            this.AddDoc.BackColor = System.Drawing.Color.SteelBlue;
            this.AddDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddDoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddDoc.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddDoc.Location = new System.Drawing.Point(44, 130);
            this.AddDoc.Name = "AddDoc";
            this.AddDoc.Size = new System.Drawing.Size(163, 53);
            this.AddDoc.TabIndex = 23;
            this.AddDoc.Text = "Add Doctor";
            this.AddDoc.UseVisualStyleBackColor = false;
            this.AddDoc.Click += new System.EventHandler(this.AddDoc_Click);
            // 
            // AddPat
            // 
            this.AddPat.BackColor = System.Drawing.Color.SteelBlue;
            this.AddPat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddPat.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddPat.Location = new System.Drawing.Point(44, 189);
            this.AddPat.Name = "AddPat";
            this.AddPat.Size = new System.Drawing.Size(163, 53);
            this.AddPat.TabIndex = 24;
            this.AddPat.Text = "Add Patient";
            this.AddPat.UseVisualStyleBackColor = false;
            this.AddPat.Click += new System.EventHandler(this.AddPat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(44, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 53);
            this.button1.TabIndex = 26;
            this.button1.Text = "Doctor List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // PatientList
            // 
            this.PatientList.BackColor = System.Drawing.Color.SteelBlue;
            this.PatientList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PatientList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PatientList.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PatientList.Location = new System.Drawing.Point(44, 248);
            this.PatientList.Name = "PatientList";
            this.PatientList.Size = new System.Drawing.Size(163, 53);
            this.PatientList.TabIndex = 27;
            this.PatientList.Text = "Patient List";
            this.PatientList.UseVisualStyleBackColor = false;
            this.PatientList.Click += new System.EventHandler(this.PatientList_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.PatientList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddPat);
            this.Controls.Add(this.AddDoc);
            this.Controls.Add(this.logutbtn);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logutbtn;
        private System.Windows.Forms.Button AddDoc;
        private System.Windows.Forms.Button AddPat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PatientList;
    }
}