namespace HMS
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView100 = new System.Windows.Forms.DataGridView();
            this.gharko = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pat_Id = new System.Windows.Forms.TextBox();
            this.Doc_Id = new System.Windows.Forms.TextBox();
            this.booking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView100)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(481, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Doctor\'s List";
            // 
            // dataGridView100
            // 
            this.dataGridView100.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView100.Location = new System.Drawing.Point(344, 77);
            this.dataGridView100.Name = "dataGridView100";
            this.dataGridView100.RowHeadersWidth = 51;
            this.dataGridView100.RowTemplate.Height = 24;
            this.dataGridView100.Size = new System.Drawing.Size(444, 361);
            this.dataGridView100.TabIndex = 11;
            this.dataGridView100.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView100_CellContentClick);
            // 
            // gharko
            // 
            this.gharko.BackColor = System.Drawing.Color.SteelBlue;
            this.gharko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gharko.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.gharko.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gharko.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gharko.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gharko.Location = new System.Drawing.Point(698, 27);
            this.gharko.Name = "gharko";
            this.gharko.Size = new System.Drawing.Size(90, 44);
            this.gharko.TabIndex = 25;
            this.gharko.Text = "Home";
            this.gharko.UseVisualStyleBackColor = false;
            this.gharko.Click += new System.EventHandler(this.gharko_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Book Your Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(319, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 403);
            this.label2.TabIndex = 27;
            this.label2.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(14, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 44);
            this.label5.TabIndex = 28;
            this.label5.Text = "Your ID\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "Doctor\'s ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Pat_Id
            // 
            this.Pat_Id.Location = new System.Drawing.Point(151, 102);
            this.Pat_Id.Name = "Pat_Id";
            this.Pat_Id.Size = new System.Drawing.Size(162, 22);
            this.Pat_Id.TabIndex = 30;
            // 
            // Doc_Id
            // 
            this.Doc_Id.Location = new System.Drawing.Point(151, 146);
            this.Doc_Id.Name = "Doc_Id";
            this.Doc_Id.Size = new System.Drawing.Size(162, 22);
            this.Doc_Id.TabIndex = 31;
            // 
            // booking
            // 
            this.booking.BackColor = System.Drawing.Color.SteelBlue;
            this.booking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.booking.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.booking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.booking.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.booking.Location = new System.Drawing.Point(18, 199);
            this.booking.Name = "booking";
            this.booking.Size = new System.Drawing.Size(102, 44);
            this.booking.TabIndex = 32;
            this.booking.Text = "Register";
            this.booking.UseVisualStyleBackColor = false;
            this.booking.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.booking);
            this.Controls.Add(this.Doc_Id);
            this.Controls.Add(this.Pat_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gharko);
            this.Controls.Add(this.dataGridView100);
            this.Controls.Add(this.label4);
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentForm";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView100)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView100;
        private System.Windows.Forms.Button gharko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pat_Id;
        private System.Windows.Forms.TextBox Doc_Id;
        private System.Windows.Forms.Button booking;
    }
}