namespace ProjektNaJPWP
{
    partial class Pytanie
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.ZegarPytanie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 7);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(301, 40);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Ile to jest x * y ";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAnswer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAnswer.Location = new System.Drawing.Point(66, 56);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(111, 54);
            this.txtAnswer.TabIndex = 1;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAnswer_KeyDown);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(213, 77);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 13);
            this.lblFeedback.TabIndex = 3;
            this.lblFeedback.Click += new System.EventHandler(this.lblFeedback_Click);
            // 
            // ZegarPytanie
            // 
            this.ZegarPytanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZegarPytanie.Location = new System.Drawing.Point(209, 136);
            this.ZegarPytanie.Name = "ZegarPytanie";
            this.ZegarPytanie.Size = new System.Drawing.Size(267, 68);
            this.ZegarPytanie.TabIndex = 4;
            this.ZegarPytanie.Text = "00:00";
            // 
            // Pytanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 311);
            this.Controls.Add(this.ZegarPytanie);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Pytanie";
            this.Text = "Pytanie";
            this.Load += new System.EventHandler(this.Pytanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label ZegarPytanie;
    }
}