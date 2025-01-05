using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjektNaJPWP.Form1;

namespace ProjektNaJPWP
{
    public partial class Wygrana : Form

    {
        
        public enum DialogResultCustom
        {
            Restart,
            Exit
        }

        public DialogResultCustom Result { get; private set; }
        private Form1 _form1v2;
        public Wygrana(Form1 form1, int wynik, string czas)
        {
            this.Name = "Wygrana";
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            _form1v2 = form1;
            

            label2.Text = $"Wynik:{wynik}";
            label3.Text = $"{czas}";
        }

        

        private void Wygrana_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            
            
                ClosingFunction(sender, e);
                Form1 form1 = new Form1();
                form1.ShowDialog();
            
                
                
            
            
                 
            
        }

        private void ClosingFunction(object sender, EventArgs e)
        {
            ApplicationState.isApplicationExiting = false;
            
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form is Form1)
                {

                    form.Close();
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Result = DialogResultCustom.Exit;
            this.DialogResult = DialogResult.OK;
            this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //ApplicationState.isApplicationExiting = true;
            this.Close();
            //MainForm_FormClosingForWin();
            EkranPowitalny ekranPowitalny = new EkranPowitalny();
            ekranPowitalny.Show();
            

        }

        
    }
}
