using System;
using System.Linq;
using System.Windows.Forms;
using static ProjektNaJPWP.Form1;

namespace ProjektNaJPWP
{
    public partial class Pytanie : Form
    {
        private int x;       // Pierwsza liczba
        private int y;       // Druga liczba
        private string op;   // Operator matematyczny (* lub /)

        private Timer clockTimer; // Timer dla zegara
        private int remainingMilliseconds; // 15 sekund w milisekundach (15 * 1000)

        bool RightAnswer = false;

        public bool isCorrect = false;

        public Pytanie()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            GenerateQuestion();
        }

        public Pytanie(int initialTimeMilliseconds = 15000) // Domyślnie 15 sekund
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            remainingMilliseconds = initialTimeMilliseconds; // Ustaw przekazany czas
            GenerateQuestion();
        }

        private void GenerateQuestion()
        {
            Random random = new Random();
            int operationType = random.Next(0, 2); // 0 = mnożenie, 1 = dzielenie

            

            if (operationType == 0) // Mnożenie
            {
                op = "×";
                x = random.Next(2, 11); // Losuje liczbę od 2 do 10
                y = random.Next(2, 11);
            }
            else // Dzielenie
            {
                op = "÷";
                y = random.Next(2, 11); // Druga liczba (dzielnik)
                x = y * random.Next(1, 11); // Pierwsza liczba (musi być wielokrotnością dzielnika)
            }

            lblQuestion.Text = $"Ile to jest {x} {op} {y}?";

            clockTimer = new Timer();
            clockTimer.Interval = 10; // Aktualizacja co 10 ms
            clockTimer.Tick += UpdateClock; // Powiązanie z metodą obsługi
            clockTimer.Start(); // Rozpoczęcie odliczania
        }

        

        private void Pytanie_Load(object sender, EventArgs e)
        {
            
        }

        

        private void TxtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true; 
                CheckAnswer(); 
            }
        }

        private void CheckAnswer()
        {
            int userAnswer;
            if (int.TryParse(txtAnswer.Text, out userAnswer)) // Sprawdź, czy wpisano liczbę
            {
                

                if (op == "×") 
                {
                    isCorrect = userAnswer == x * y;
                }
                else if (op == "÷") 
                {
                    isCorrect = userAnswer == x / y;
                }

                if (isCorrect)
                {
                    lblFeedback.Text = "Dobrze!";
                    lblFeedback.ForeColor = System.Drawing.Color.Green;
                    RightAnswer = true;
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblFeedback.Text = "Źle, spróbuj jeszcze raz.";
                    lblFeedback.ForeColor = System.Drawing.Color.Red;
                    clockTimer.Stop();
                    RightAnswer = false;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    
                    


                }

                GenerateQuestion(); // Generuje nowe pytanie
                txtAnswer.Clear(); // Czyści pole odpowiedzi
            }
            else
            {
                lblFeedback.Text = "Wpisz poprawną liczbę.";
                lblFeedback.ForeColor = System.Drawing.Color.Red;

            }
        }

        private void UpdateClock(object sender, EventArgs e)
        {
            remainingMilliseconds -= 15; // Odejmij 15 ms(w celu uzyskania realistycznego stopera)

            if (remainingMilliseconds <= 0 && !RightAnswer)
         //dzięki !RightAnswerjesli odpowiedz była dobra i zostanie zamkniete okno to nie wyświetli się okno Przegrana w środku gry
            {
                clockTimer.Stop(); // Zatrzymaj zegar po osiągnięciu 0
                ZegarPytanie.Text = "Czas: 00:00"; // Wyświetl 0
                ZegarPytanie.ForeColor = System.Drawing.Color.Red;
                
                

                this.DialogResult = DialogResult.OK; // Zamknij obecne okno pytania
                this.Close();



            }
            

             


            
            else
            {
                int seconds = remainingMilliseconds / 1000; // Całkowite sekundy
                int milliseconds = (remainingMilliseconds % 1000) / 10; // Dziesiątki milisekund

                if (remainingMilliseconds > 5000)
                {
                    ZegarPytanie.ForeColor = System.Drawing.Color.Green; // Zielony dla czasu > 5 sekund
                }
                else
                {
                    ZegarPytanie.ForeColor = System.Drawing.Color.Red; // Czerwony dla czasu <= 5 sekund
                }


                ZegarPytanie.Text = $"Czas: {seconds:D2}:{milliseconds:D2}";
            }
        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }
    }
}
