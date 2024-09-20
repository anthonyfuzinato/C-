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
                LSB_jogadores.Items.Add("José Sá");
            }
            else if (CMB_posicao.Text == "Defesa")
            {
                LSB_jogadores.Items.Add("João Cancelo");
                LSB_jogadores.Items.Add("Nelson Semedo");
                LSB_jogadores.Items.Add("António Silva");
                LSB_jogadores.Items.Add("Gonçalo Inacio");
            }
            else if (CMB_posicao.Text == "Médio")
            {
                LSB_jogadores.Items.Add("João Neves");
                LSB_jogadores.Items.Add("Mateus Nunes");
                LSB_jogadores.Items.Add("Bruno Fernandes");
            }
            else
            {
                LSB_jogadores.Items.Add("Cristiano Ronaldo");
                LSB_jogadores.Items.Add("Rafael Leão");
                LSB_jogadores.Items.Add("Gonçalo Ramos");
            }
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LSB_equipa
        }
    }
}
