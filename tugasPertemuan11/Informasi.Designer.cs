namespace tugasPertemuan11
{
    partial class Informasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informasi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKereta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStasiun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnKereta
            // 
            this.btnKereta.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnKereta.Font = new System.Drawing.Font("Goudy Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKereta.Location = new System.Drawing.Point(237, 320);
            this.btnKereta.Name = "btnKereta";
            this.btnKereta.Size = new System.Drawing.Size(130, 44);
            this.btnKereta.TabIndex = 1;
            this.btnKereta.Text = "Kereta";
            this.btnKereta.UseVisualStyleBackColor = false;
            this.btnKereta.Click += new System.EventHandler(this.btnKereta_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(436, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Penumpang";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStasiun
            // 
            this.btnStasiun.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnStasiun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStasiun.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStasiun.Location = new System.Drawing.Point(662, 322);
            this.btnStasiun.Name = "btnStasiun";
            this.btnStasiun.Size = new System.Drawing.Size(149, 44);
            this.btnStasiun.TabIndex = 3;
            this.btnStasiun.Text = "Stasiun";
            this.btnStasiun.UseVisualStyleBackColor = false;
            this.btnStasiun.Click += new System.EventHandler(this.btnStasiun_Click);
            // 
            // Informasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 619);
            this.Controls.Add(this.btnStasiun);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnKereta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Informasi";
            this.Text = "Informasi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKereta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStasiun;
    }
}