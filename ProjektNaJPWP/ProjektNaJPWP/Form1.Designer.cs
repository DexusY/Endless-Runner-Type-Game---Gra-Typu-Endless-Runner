namespace ProjektNaJPWP
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameScore = new System.Windows.Forms.Label();
            this.TimerGame = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.Label();
            this.przeszkoda2 = new System.Windows.Forms.PictureBox();
            this.przeszkoda = new System.Windows.Forms.PictureBox();
            this.gracz = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.przeszkoda2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przeszkoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 15;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // GameScore
            // 
            this.GameScore.AutoSize = true;
            this.GameScore.Location = new System.Drawing.Point(34, 27);
            this.GameScore.Name = "GameScore";
            this.GameScore.Size = new System.Drawing.Size(35, 13);
            this.GameScore.TabIndex = 4;
            this.GameScore.Text = "label1";
            // 
            // TimerGame
            // 
            this.TimerGame.AutoSize = true;
            this.TimerGame.Location = new System.Drawing.Point(747, 27);
            this.TimerGame.Name = "TimerGame";
            this.TimerGame.Size = new System.Drawing.Size(35, 13);
            this.TimerGame.TabIndex = 5;
            this.TimerGame.Text = "label1";
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Location = new System.Drawing.Point(531, 27);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(34, 13);
            this.Menu.TabIndex = 8;
            this.Menu.Text = "Menu";
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // przeszkoda2
            // 
            this.przeszkoda2.BackColor = System.Drawing.Color.Transparent;
            this.przeszkoda2.Image = global::ProjektNaJPWP.Properties.Resources.przeszkoda2;
            this.przeszkoda2.Location = new System.Drawing.Point(466, 353);
            this.przeszkoda2.Name = "przeszkoda2";
            this.przeszkoda2.Size = new System.Drawing.Size(47, 43);
            this.przeszkoda2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.przeszkoda2.TabIndex = 3;
            this.przeszkoda2.TabStop = false;
            this.przeszkoda2.Tag = "przeszkoda";
            // 
            // przeszkoda
            // 
            this.przeszkoda.BackColor = System.Drawing.Color.Transparent;
            this.przeszkoda.Image = global::ProjektNaJPWP.Properties.Resources.przeszkoda1;
            this.przeszkoda.Location = new System.Drawing.Point(396, 363);
            this.przeszkoda.Name = "przeszkoda";
            this.przeszkoda.Size = new System.Drawing.Size(28, 33);
            this.przeszkoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.przeszkoda.TabIndex = 2;
            this.przeszkoda.TabStop = false;
            this.przeszkoda.Tag = "przeszkoda";
            // 
            // gracz
            // 
            this.gracz.BackColor = System.Drawing.Color.Transparent;
            this.gracz.Image = global::ProjektNaJPWP.Properties.Resources.runner;
            this.gracz.Location = new System.Drawing.Point(208, 335);
            this.gracz.Name = "gracz";
            this.gracz.Size = new System.Drawing.Size(53, 62);
            this.gracz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gracz.TabIndex = 1;
            this.gracz.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 396);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(880, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 401);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.TimerGame);
            this.Controls.Add(this.GameScore);
            this.Controls.Add(this.przeszkoda2);
            this.Controls.Add(this.przeszkoda);
            this.Controls.Add(this.gracz);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Tag = "przeszkoda";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.przeszkoda2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przeszkoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gracz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox gracz;
        private System.Windows.Forms.PictureBox przeszkoda;
        private System.Windows.Forms.PictureBox przeszkoda2;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label GameScore;
        private System.Windows.Forms.Label TimerGame;
        private System.Windows.Forms.Label Menu;
    }
}

