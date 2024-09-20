namespace primeiro_projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("aaaaaa", "Aaaaaaa", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lbl_mensagem(object sender, EventArgs e)
        {
            lbl.Text = "Hello World";
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_nao1_MouseMove(object sender, MouseEventArgs e)
        {
            btn_nao1.Visible = false;
            btn_nao1.Visible = true;

        }

        private void btn_nao2_MouseMove(object sender, MouseEventArgs e)
        {
            btn_nao1.Visible = false;
            btn_nao1.Visible = true;
        }
    }
}

