namespace HMS
{
    partial class LoginAs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAs));
            this.AdminAcc = new System.Windows.Forms.Button();
            this.DocAcc = new System.Windows.Forms.Button();
            this.PatientAcc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminAcc
            // 
            this.AdminAcc.BackColor = System.Drawing.Color.Indigo;
            this.AdminAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAcc.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.AdminAcc.Location = new System.Drawing.Point(44, 132);
            this.AdminAcc.Name = "AdminAcc";
            this.AdminAcc.Size = new System.Drawing.Size(146, 31);
            this.AdminAcc.TabIndex = 0;
            this.AdminAcc.Text = "Click Here";
            this.AdminAcc.UseVisualStyleBackColor = false;
            this.AdminAcc.Click += new System.EventHandler(this.button1_Click);
            // 
            // DocAcc
            // 
            this.DocAcc.BackColor = System.Drawing.Color.Indigo;
            this.DocAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DocAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocAcc.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.DocAcc.Location = new System.Drawing.Point(44, 203);
            this.DocAcc.Name = "DocAcc";
            this.DocAcc.Size = new System.Drawing.Size(146, 36);
            this.DocAcc.TabIndex = 1;
            this.DocAcc.Text = "Click Here";
            this.DocAcc.UseVisualStyleBackColor = false;
            this.DocAcc.Click += new System.EventHandler(this.DocAcc_Click);
            // 
            // PatientAcc
            // 
            this.PatientAcc.BackColor = System.Drawing.Color.Indigo;
            this.PatientAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PatientAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAcc.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PatientAcc.Location = new System.Drawing.Point(44, 277);
            this.PatientAcc.Name = "PatientAcc";
            this.PatientAcc.Size = new System.Drawing.Size(146, 33);
            this.PatientAcc.TabIndex = 2;
            this.PatientAcc.Text = "Click Here";
            this.PatientAcc.UseVisualStyleBackColor = false;
            this.PatientAcc.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(39, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login As Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(40, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login As Doctor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(40, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login As Patient";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(36, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(537, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hospital Management System";
            // 
            // LoginAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatientAcc);
            this.Controls.Add(this.DocAcc);
            this.Controls.Add(this.AdminAcc);
            this.Name = "LoginAs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginAs";
            this.Load += new System.EventHandler(this.LoginAs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminAcc;
        private System.Windows.Forms.Button DocAcc;
        private System.Windows.Forms.Button PatientAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}