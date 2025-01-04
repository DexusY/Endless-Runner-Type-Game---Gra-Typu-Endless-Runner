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
    public partial class Menu : Form
    {
        
        public enum DialogResultCustom
        {
            Restart,
            Exit
        }

        public DialogResultCustom Result { get; private set; }
        private Form1 _form1;
        public Menu(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;

            this.StartPosition = FormStartPosition.CenterParent;
            this.FormClosing += MainForm_FormClosingForMenu;
        }

        private void MainForm_FormClosingForMenu(object sender, FormClosingEventArgs e)
        {
            bool isForm1Open = Application.OpenForms["Form1"] != null;

            if (isForm1Open)
            {
                
                ApplicationState.isApplicationExiting = false;
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {

            ApplicationState.isApplicationExiting = true;

            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form is Form1) 
                {
                    
                    form.Close(); 
                }
            }
            this.Close();

            EkranPowitalny ekranPowitalny = new EkranPowitalny();
            ekranPowitalny.Show();
            

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplicationState.isApplicationExiting = false;
            if (_form1 != null)
            {
                this.Close();
                _form1.Reset();
            };

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Result = DialogResultCustom.Exit;
            this.DialogResult = DialogResult.OK;
            this.Close();
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        
    }
}
