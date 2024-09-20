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
    public partial class frm_Saida : Form
    {
        public frm_Saida(int N_respostas_certas)
        {
            int Respostas_certas = N_respostas_certas;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Saida_Load(object sender, EventArgs e)
        {
            label1.Text = "Acertou em"+ Respostas_certas + " perguntas"
        }
    }
}
