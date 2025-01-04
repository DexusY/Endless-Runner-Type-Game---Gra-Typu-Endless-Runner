namespace ProjektNaJPWP
{
    partial class EkranPowitalny
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
            this.Start = new System.Windows.Forms.Button();
            this.Wyjście = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Start.Location = new System.Drawing.Point(72, 141);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(300, 94);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Wyjście
            // 
            this.Wyjście.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyjście.Location = new System.Drawing.Point(478, 141);
            this.Wyjście.Name = "Wyjście";
            this.Wyjście.Size = new System.Drawing.Size(300, 94);
            this.Wyjście.TabIndex = 1;
            this.Wyjście.Text = "Wyjście";
            this.Wyjście.UseVisualStyleBackColor = true;
            this.Wyjście.Click += new System.EventHandler(this.Wyjście_Click);
            // 
            // EkranPowitalny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 401);
            this.Controls.Add(this.Wyjście);
            this.Controls.Add(this.Start);
            this.Name = "EkranPowitalny";
            this.Text = "EkranPowitalny";
            this.Load += new System.EventHandler(this.EkranPowitalny_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Wyjście;
    }
}