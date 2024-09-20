namespace Jogo_Pong
{
    public partial class Form1 : Form
    {

        string direcao_horizontal = "direita";
        string direcao_vertical = "baixo";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_RaqueteDireita.Location = new Point(this.Width - lbl_RaqueteDireita.Width - 10, this.Height / 2 - lbl_RaqueteDireita.Height);
            lbl_RaqueteEsquerda.Location = new Point(10, this.Height / 2 - lbl_RaqueteEsquerda.Height);
        }

        private void tm_tempojogo_Tick(object sender, EventArgs e)
        {
            lbl_tempo.Text = pb_TempoJogo.Value.ToString();
            pb_TempoJogo.Value -= 1;
            if (pb_TempoJogo.Value == 0)
            {
                tm_tempojogo.Stop();
                MessageBox.Show("Terminou o tempo de jogo, Game Over!", "Pong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void tm_bola_Tick(object sender, EventArgs e)
        {
            // Testar as colisao da bola na parede direita
            if (pic_bola.Left > this.Width - pic_bola.Width - lbl_RaqueteDireita.Width)
                direcao_horizontal = "esquerda";

            // Testar as colisao da bola na parede direita
            if (pic_bola.Left < lbl_RaqueteEsquerda.Width)
                direcao_horizontal = "direita";

            // Testar as colisao da bola na parede de cima
            if (pic_bola.Top < 0)
                direcao_vertical = "baixo";

            // Testar as colisao da bola na parede de baixo
            if (pic_bola.Top > this.Height)
                direcao_vertical = "cima";

            // Mover a bola

            // testar movimento horizontal da bola 
            if (direcao_horizontal == "direita")
                pic_bola.Left += 10;
            else
                pic_bola.Left -= 10;

            // testar movimento vertical da bola 
            if (direcao_vertical == "cima")
                pic_bola.Top -= 10;
            else
                pic_bola.Top += 10;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 83 && lbl_RaqueteDireita.Top < this.Height - lbl_RaqueteEsquerda.Height)
                lbl_RaqueteEsquerda.Top += 15;
            if (e.KeyValue == 87 && lbl_RaqueteEsquerda.Top > 0)
                lbl_RaqueteEsquerda.Top -= 15;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 's' && lbl_RaqueteEsquerda.Top < this.Height - lbl_RaqueteEsquerda.Height)
                lbl_RaqueteEsquerda.Top += 15;

            if (e.KeyChar == 'w' && lbl_RaqueteEsquerda.Top > 0)
                lbl_RaqueteEsquerda.Top -= 15;
        }
    }
}
