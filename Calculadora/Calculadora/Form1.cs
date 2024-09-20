using System.Diagnostics.Eventing.Reader;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            testar_caixa();

        }
        private void testar_caixa()
        {
            if (txt_valor1.Text != "" && txt_valor2.Text != "")
            {
                btn_calcular.Enabled = true;
            }
            else
            {
                btn_calcular.Enabled = false;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_valor2_TextChanged(object sender, EventArgs e)
        {
            testar_caixa();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdb_soma_CheckedChanged(object sender, EventArgs e)
        {
            lbl_operador.Text = "+";
        }

        private void rdb_subtraçao_CheckedChanged(object sender, EventArgs e)
        {
            lbl_operador.Text = "-";
        }

        private void rdb_dividir_CheckedChanged(object sender, EventArgs e)
        {
            lbl_operador.Text = "/";
        }

        private void rdb_multiplicaçao_CheckedChanged(object sender, EventArgs e)
        {
            lbl_operador.Text = "*";
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (lbl_operador.Text == "+")
            {
                lbl_resultado.Text = Convert.ToString(Convert.ToInt32(txt_valor1.Text) + Convert.ToInt32(txt_valor2.Text));
            }
            else if (lbl_operador.Text == "-")
                lbl_resultado.Text = Convert.ToString(Convert.ToInt32(txt_valor1.Text) - Convert.ToInt32(txt_valor2.Text));
            else if (lbl_operador.Text == "*")
                lbl_resultado.Text = Convert.ToString(Convert.ToInt32(txt_valor1.Text) * Convert.ToInt32(txt_valor2.Text));
            else if (lbl_operador.Text == "/")
                try
                {
                    lbl_resultado.Text = Convert.ToString(Convert.ToInt32(txt_valor1.Text) / Convert.ToInt32(txt_valor2.Text));
                }
                catch (DivideByZeroException)
                { MessageBox.Show("Nao pode dividir por zero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)}
            else
                MessageBox.Show("Tem de selecionar uma operaçao", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txt_valor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
