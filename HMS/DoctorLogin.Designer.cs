namespace HMS
{
    partial class DoctorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.duser = new System.Windows.Forms.TextBox();
            this.puser = new System.Windows.Forms.TextBox();
            this.dlogbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(40, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(36, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(537, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hospital Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(40, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // duser
            // 
            this.duser.Location = new System.Drawing.Point(152, 152);
            this.duser.Name = "duser";
            this.duser.Size = new System.Drawing.Size(236, 22);
            this.duser.TabIndex = 10;
            this.duser.TextChanged += new System.EventHandler(this.duser_TextChanged);
            // 
            // puser
            // 
            this.puser.Location = new System.Drawing.Point(152, 202);
            this.puser.Name = "puser";
            this.puser.Size = new System.Drawing.Size(236, 22);
            this.puser.TabIndex = 11;
            this.puser.TextChanged += new System.EventHandler(this.puser_TextChanged);
            // 
            // dlogbtn
            // 
            this.dlogbtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.dlogbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dlogbtn.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlogbtn.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dlogbtn.Location = new System.Drawing.Point(152, 249);
            this.dlogbtn.Name = "dlogbtn";
            this.dlogbtn.Size = new System.Drawing.Size(79, 32);
            this.dlogbtn.TabIndex = 12;
            this.dlogbtn.Text = "Log In";
            this.dlogbtn.UseVisualStyleBackColor = false;
            this.dlogbtn.Click += new System.EventHandler(this.dlogbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(38, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Doctor Login";
            // 
            // DoctorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dlogbtn);
            this.Controls.Add(this.puser);
            this.Controls.Add(this.duser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DoctorLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorLogin";
            this.Load += new System.EventHandler(this.DoctorLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox duser;
        private System.Windows.Forms.TextBox puser;
        private System.Windows.Forms.Button dlogbtn;
        private System.Windows.Forms.Label label4;
    }
}