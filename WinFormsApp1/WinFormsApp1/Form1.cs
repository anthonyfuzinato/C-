namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CMB_posicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            LSB_jogadores.Items.Clear();
            LSB_jogadores.Enabled = true;
            if (CMB_posicao.Text == "Guarda-Redes")
            {
                LSB_jogadores.Items.Add("Diogo Costa");
                LSB_jogadores.Items.Add("Rui patricio");
                LSB_jogadores.Items.Add("Jos� S�");
            }
            else if (CMB_posicao.Text == "Defesa")
            {
                LSB_jogadores.Items.Add("Jo�o Cancelo");
                LSB_jogadores.Items.Add("Nelson Semedo");
                LSB_jogadores.Items.Add("Ant�nio Silva");
                LSB_jogadores.Items.Add("Gon�alo Inacio");
            }
            else if (CMB_posicao.Text == "M�dio")
            {
                LSB_jogadores.Items.Add("Jo�o Neves");
                LSB_jogadores.Items.Add("Mateus Nunes");
                LSB_jogadores.Items.Add("Bruno Fernandes");
            }
            else
            {
                LSB_jogadores.Items.Add("Cristiano Ronaldo");
                LSB_jogadores.Items.Add("Rafael Le�o");
                LSB_jogadores.Items.Add("Gon�alo Ramos");
            }
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LSB_equipa
        }
    }
}
