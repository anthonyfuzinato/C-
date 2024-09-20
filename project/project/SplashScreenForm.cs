using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class carregamento : UserControl
    {
        public carregamento()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += progressBar1.Step;
            }
            if (progressBar1.Value == 100)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
