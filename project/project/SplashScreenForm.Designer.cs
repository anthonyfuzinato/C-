namespace project
{
    partial class carregamento
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            lbl_carregar = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.Location = new Point(243, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(62, 239);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(495, 27);
            progressBar1.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // lbl_carregar
            // 
            lbl_carregar.AutoSize = true;
            lbl_carregar.BackColor = Color.White;
            lbl_carregar.ForeColor = Color.Black;
            lbl_carregar.Location = new Point(258, 193);
            lbl_carregar.Name = "lbl_carregar";
            lbl_carregar.Size = new Size(95, 15);
            lbl_carregar.TabIndex = 2;
            lbl_carregar.Text = "JOGO DA VELHA";
            // 
            // carregamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_carregar);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "carregamento";
            Size = new Size(611, 305);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_carregar;
    }
}
