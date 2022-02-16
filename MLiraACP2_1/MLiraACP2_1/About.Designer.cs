
namespace MLiraACP2_1
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Descrip = new System.Windows.Forms.Label();
            this.lbl_VersiP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Name.Location = new System.Drawing.Point(840, 446);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(151, 36);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Miriam Lira";
            // 
            // lbl_Descrip
            // 
            this.lbl_Descrip.AutoSize = true;
            this.lbl_Descrip.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descrip.ForeColor = System.Drawing.Color.Black;
            this.lbl_Descrip.Location = new System.Drawing.Point(34, 648);
            this.lbl_Descrip.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Descrip.Name = "lbl_Descrip";
            this.lbl_Descrip.Size = new System.Drawing.Size(1649, 288);
            this.lbl_Descrip.TabIndex = 1;
            this.lbl_Descrip.Text = resources.GetString("lbl_Descrip.Text");
            this.lbl_Descrip.Click += new System.EventHandler(this.lbl_Descrip_Click);
            // 
            // lbl_VersiP
            // 
            this.lbl_VersiP.AutoSize = true;
            this.lbl_VersiP.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VersiP.ForeColor = System.Drawing.Color.Black;
            this.lbl_VersiP.Location = new System.Drawing.Point(34, 483);
            this.lbl_VersiP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_VersiP.Name = "lbl_VersiP";
            this.lbl_VersiP.Size = new System.Drawing.Size(495, 144);
            this.lbl_VersiP.TabIndex = 2;
            this.lbl_VersiP.Text = "Version 1.1\r\nMicrosoft Visual Studio Community 2019\r\nVersion 16.11.2\r\n9/19/2021";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1116, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Thistle;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(1575, 961);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(190, 65);
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1959, 1058);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_VersiP);
            this.Controls.Add(this.lbl_Descrip);
            this.Controls.Add(this.lbl_Name);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Descrip;
        private System.Windows.Forms.Label lbl_VersiP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Close;
    }
}