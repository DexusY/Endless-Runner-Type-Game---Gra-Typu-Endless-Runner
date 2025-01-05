using System;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektNaJPWP
{
    public partial class Form1 : Form
    {
        Image backgroundImage;

        int przeszkodaSpeed = 12;
        int szerokoscOkno;
        int score = 0;
        int speed = 10;

        private bool questionAskedFor10 = false;//flaga dla pierwszego pytania(dla tylko jednej flagi działa tylko pierwsze okno)
        private bool questionAskedFor20 = false;
        private bool questionAskedFor30 = false;

        
        public static class ApplicationState
        {
            public static bool isApplicationExiting = false; 
        }

        

        bool jumping = true;
        bool gameover = false;

        Random random = new Random();
        List<PictureBox> obstacles = new List<PictureBox>();
        PictureBox hitBox = new PictureBox();

     
        
        
        private Timer clockTimer; // Timer dla licznika czasu
        private int elapsedMilliseconds = 0; //pływający czas w milisekundach



        public Form1()
        {
            
            InitializeComponent();
            ApplicationState.isApplicationExiting = false;
            this.StartPosition = FormStartPosition.Manual; // Ręczna pozycja
            this.Location = new Point(100, 100); // Określona pozycja (x, y)
            GameSetUp();
            Reset();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        

        

        

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;
            Canvas.DrawImage(backgroundImage,0,-26);//(obraz,PozycjaX,PozycjaY)
            Canvas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Canvas.InterpolationMode = InterpolationMode.HighQualityBicubic;

        }




        private void GameTimerEvent(object sender, EventArgs e)
        {

            

            MoveObstacles();
            GameScore.Text = "Wynik: " + score;

            hitBox.Left = gracz.Right - (hitBox.Width + 15);//ustawienie hitboxu na środek postaci
            hitBox.Top = gracz.Top + 5;

            if (jumping) //skaknie
            {
                gracz.Top -= speed;

                if (gracz.Top < 232) //250
                {
                    speed = -10;
                }
                if (gracz.Top > 334) //352
                {
                    jumping = false;
                    gracz.Top = 335; //353
                    speed = 10;
                }
            }
            if (!ApplicationState.isApplicationExiting)
            {

            
            foreach (PictureBox x in obstacles)
            {

                if (x.Bounds.IntersectsWith(hitBox.Bounds))
                {



                    GameTimer.Stop();
                    clockTimer.Stop();
                    gameover = true;
                    gracz.Top = 335;
                    GameOver();
                    return;
                }


            }
            }
            else if(ApplicationState.isApplicationExiting)
            {
                GameTimer.Stop();
                clockTimer.Stop();
                return;
            }
            

            if (score == 10 && !questionAskedFor10)
            {
                GameTimer.Stop();
                questionAskedFor10 = true; // Ustaw flagę, aby zapobiec wielokrotnemu otwieraniu

                Pytanie menuPytanie = new Pytanie(15000);           
                var result = menuPytanie.ShowDialog();

                if (result == DialogResult.OK)
                {                    
                    backgroundImage = Properties.Resources.tlo;
                    this.Invalidate();
                    GameTimer.Start();
                }
                else
                {
                    GameOverForAsk();
                }
                

            }



            if (score == 20 && !questionAskedFor20)
            {
                GameTimer.Stop();
                questionAskedFor20 = true;
                Pytanie menuPytanie = new Pytanie(10000);
                var result = menuPytanie.ShowDialog();

                if (result == DialogResult.OK)
                {
                    backgroundImage = Properties.Resources.tlo2;
                    this.Invalidate();
                    GameTimer.Start();

                }
                else
                {
                    GameOverForAsk();
                }
            }

            if(score == 30 && !questionAskedFor30)
            {
                GameTimer.Stop();
                questionAskedFor10 = true;
                
                Pytanie menuPytanie = new Pytanie(6000);//6000
                var result = menuPytanie.ShowDialog();  

                if (result == DialogResult.OK && menuPytanie.isCorrect) 
                {
                    ApplicationState.isApplicationExiting = true;
                    menuPytanie.Close();
                    GameTimer.Stop();
                    clockTimer.Stop();
                    
                    Wygrana wygrana = new Wygrana(this, GetScore(), ClockTime());
                    wygrana.ShowDialog();
                    
                    this.Close();
                    

                }

                else
                {
                    
                    GameOverForAsk();  
                }

                //GameTimer.Start();
            }







        }


        private void GameSetUp()
        {
            
            backgroundImage = Properties.Resources.tlo1;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            szerokoscOkno = this.ClientSize.Width;
            this.BackColor = Color.Black;
            obstacles.Add(przeszkoda);
            obstacles.Add(przeszkoda2);

            
            GameScore.ForeColor = Color.Black;
            GameScore.BackColor = Color.Transparent;
            GameScore.Text = "Wynik: 0";

            TimerGame.ForeColor = Color.Black;
            TimerGame.BackColor = Color.Transparent;
            TimerGame.Text = "Czas: 0:00:00";

            Menu.ForeColor = Color.Black;
            Menu.BackColor = Color.Transparent;
            Menu.Width = 200;
            Menu.Height = 100;
            Menu.BorderStyle = BorderStyle.FixedSingle; 
            Menu.Padding = new Padding(1);

            hitBox.Width = gracz.Width / 2;
            hitBox.Height = gracz.Height - 10;

            this.Controls.Add(hitBox);
            gameover = false;


            clockTimer = new Timer();
            clockTimer.Interval = 10; // Aktualizacja co 10 ms
            clockTimer.Tick += UpdateClock; 



        }

        public void Reset()
        {
            gracz.Image = Properties.Resources.runner;//gracz
            gracz.Top = 335;

            przeszkoda.Left = szerokoscOkno + random.Next(200, 300); //ustawienie przeszkody o odleglosc 880+(100;200)
            przeszkoda2.Left = przeszkoda.Left + random.Next(400, 500); //600 700

            GameTimer.Start();
            clockTimer.Start(); // Uruchomienie timera czasu gry
            elapsedMilliseconds = 0; // Zresetowanie czasu
            TimerGame.Text = "Czas: 0:00:00"; // Reset licznika
            score = 0;
            speed = 10;
            gameover = false;
            jumping = false;
            przeszkodaSpeed = 12;
            questionAskedFor10 = false;
            questionAskedFor20 = false;

        }

       

        private void MoveObstacles()
        {
            

            if(true)
            {
                
                if(score >= 0 && score <= 9)
                {
                    przeszkoda.Left -= przeszkodaSpeed;
                    przeszkoda2.Left -= przeszkodaSpeed;
                }

                if (score >= 10 && score <= 19) 
                {
                    przeszkoda.Left -= przeszkodaSpeed + 5;
                    przeszkoda2.Left -= przeszkodaSpeed + 5;
                }

                if(score >= 20)
                {
                    przeszkoda.Left -= przeszkodaSpeed + 10;
                    przeszkoda2.Left -= przeszkodaSpeed + 10;
                }
            }

            // Jeśli pierwsza przeszkoda wychodzi poza ekran
            if (przeszkoda.Left < -100)
            {
                przeszkoda.Left = przeszkoda2.Left + przeszkoda2.Width + szerokoscOkno + random.Next(50, 100);
                //tworzy nastepny obiekt w lokaliacji +(50 / 100) od początku okna
                score += 1;

                
            }

            
            if (przeszkoda2.Left < -100)
            {
                przeszkoda2.Left = przeszkoda.Left + przeszkoda.Width + szerokoscOkno + random.Next(60, 100);
                
                score += 1;
            }
        }

        private void GameOver()
        {
            GameTimer.Stop();
            clockTimer.Stop(); 
            gameover = true;

            using (Przegrana dialog = new Przegrana())
            {
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (dialog.Result == Przegrana.DialogResultCustom.Restart)
                    {
                        Reset(); 
                    }
                    else if (dialog.Result == Przegrana.DialogResultCustom.Exit)
                    {
                        Application.Exit(); 
                        Environment.Exit(0);
                    }
                }
            }
        }

        public void GameOverForAsk() //dla złej odpowiedzi
        {
            GameTimer.Stop();
            clockTimer.Stop(); // Zatrzymanie timera czasu gry
            gameover = true;

            using (Przegrana dialog = new Przegrana())
            {
                var result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (dialog.Result == Przegrana.DialogResultCustom.Restart)
                    {
                        Reset(); 
                    }
                    else if (dialog.Result == Przegrana.DialogResultCustom.Exit)
                    {
                        Application.Exit(); 
                        Environment.Exit(0);
                    }
                }
            }
        }

        public int GetScore()
        {
            return score;
        }

        public string ClockTime()
        {
            return TimerGame.Text;
        }


        public void UpdateClock(object sender, EventArgs e)
        {
            elapsedMilliseconds += 20; // Dodaj 10 ms

            int minutes = elapsedMilliseconds / 60000;
            int seconds = (elapsedMilliseconds % 60000) / 1000;
            int milliseconds = elapsedMilliseconds % 1000 / 10;

            TimerGame.Text = $"Czas: {minutes}:{seconds:D2}:{milliseconds:D2}";
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (!gameover)
            {
                if (e.KeyCode == Keys.Space && !jumping)
                {
                    jumping = true;
                }
                if (e.KeyCode == Keys.Down && !jumping)
                {
                    

                    gracz.Top = 393;
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && !gameover)
            {
                gracz.Image = Properties.Resources.runner;
                gracz.Top = 353;
                
            }

            if (e.KeyCode == Keys.Enter && gameover)
            {
                Reset();
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            clockTimer.Stop();
            ApplicationState.isApplicationExiting = true;
            
            Menu menu = new Menu(this);
            menu.ShowDialog();
            

            GameTimer.Start();
            clockTimer.Start();
            
        }

        private void ShowQuestionForm()
        {
            using (Pytanie questionForm = new Pytanie())
            {
                var result = questionForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    
                    Reset(); 
                }
                else
                {
                    
                    GameOver();
                }
            }
        }
    }
}
