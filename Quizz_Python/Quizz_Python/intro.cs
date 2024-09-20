using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz_Python
{
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Form frm_jogo = new Form();
            frm_jogo.Show();
            timer1.Stop();

        }
    }
}
