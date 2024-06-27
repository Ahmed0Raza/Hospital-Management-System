namespace HMS
{
    partial class DocPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocPatients));
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.ghar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Your Patients";
            // 
            // dataGridView11
            // 
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView11.Location = new System.Drawing.Point(12, 92);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.RowHeadersWidth = 51;
            this.dataGridView11.RowTemplate.Height = 24;
            this.dataGridView11.Size = new System.Drawing.Size(850, 346);
            this.dataGridView11.TabIndex = 11;
            this.dataGridView11.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView11_CellContentClick);
            // 
            // ghar
            // 
            this.ghar.BackColor = System.Drawing.Color.SteelBlue;
            this.ghar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ghar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.ghar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ghar.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ghar.Location = new System.Drawing.Point(772, 36);
            this.ghar.Name = "ghar";
            this.ghar.Size = new System.Drawing.Size(90, 44);
            this.ghar.TabIndex = 26;
            this.ghar.Text = "Home";
            this.ghar.UseVisualStyleBackColor = false;
            this.ghar.Click += new System.EventHandler(this.ghar_Click);
            // 
            // DocPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.ghar);
            this.Controls.Add(this.dataGridView11);
            this.Controls.Add(this.label4);
            this.Name = "DocPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocPatients";
            this.Load += new System.EventHandler(this.DocPatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.Button ghar;
    }
}