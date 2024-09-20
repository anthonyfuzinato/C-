namespace app_misturador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HSC_vermelho_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_vermelho.Text = HSC_vermelho.Value.ToString();
            this.BackColor = Color.FromArgb(Convert.ToInt32(lbl_vermelho.Text), Convert.ToInt32(lbl_Verde.Text), Convert.ToInt32(lbl_Azul.Text));
        }

        private void lbl_vermelho_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Azul_Click(object sender, EventArgs e)
        {

        }

        private void HSC_Azul_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_Azul.Text = HSC_Azul.Value.ToString();
            this.BackColor = Color.FromArgb(Convert.ToInt32(lbl_vermelho.Text), Convert.ToInt32(lbl_Verde.Text), Convert.ToInt32(lbl_Azul.Text));
        }

        private void HSC_Verde_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_Verde.Text = HSC_Verde.Value.ToString();
            this.BackColor = Color.FromArgb(Convert.ToInt32(lbl_vermelho.Text), Convert.ToInt32(lbl_Verde.Text), Convert.ToInt32(lbl_Azul.Text));
        }
    }
}
