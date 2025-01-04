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
    public partial class EkranPowitalny : Form
    {
        public EkranPowitalny()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual; 
            this.Location = new Point(100, 100); 
        }

        private void EkranPowitalny_Load(object sender, EventArgs e)
       {
            
       }

        private void Start_Click(object sender, EventArgs e)
        {
            ApplicationState.isApplicationExiting = false;
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Wyjście_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

