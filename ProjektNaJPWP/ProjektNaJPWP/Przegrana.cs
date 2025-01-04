using System;
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
    public partial class Przegrana : Form
    {
        public enum DialogResultCustom
        {
            Restart,
            Exit
        }

        public DialogResultCustom Result { get; private set; }

        public Przegrana()
        {
            InitializeComponent();
            this.Name = "Przegrana";
            this.StartPosition = FormStartPosition.CenterParent;
        }

        

        private void Przegrana_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Result = DialogResultCustom.Restart;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result = DialogResultCustom.Exit;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
