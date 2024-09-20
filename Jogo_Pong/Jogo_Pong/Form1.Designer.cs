namespace Jogo_Pong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_RaqueteEsquerda = new Label();
            lbl_RaqueteDireita = new Label();
            pb_TempoJogo = new ProgressBar();
            groupBox1 = new GroupBox();
            tm_tempojogo = new System.Windows.Forms.Timer(components);
            lbl_tempo = new Label();
            pic_bola = new PictureBox();
            tm_bola = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_bola).BeginInit();
            SuspendLayout();
            // 
            // lbl_RaqueteEsquerda
            // 
            lbl_RaqueteEsquerda.BackColor = Color.Purple;
            lbl_RaqueteEsquerda.Location = new Point(12, 185);
            lbl_RaqueteEsquerda.Name = "lbl_RaqueteEsquerda";
            lbl_RaqueteEsquerda.Size = new Size(16, 75);
            lbl_RaqueteEsquerda.TabIndex = 0;
            // 
            // lbl_RaqueteDireita
            // 
            lbl_RaqueteDireita.BackColor = Color.Fuchsia;
            lbl_RaqueteDireita.Location = new Point(772, 189);
            lbl_RaqueteDireita.Name = "lbl_RaqueteDireita";
            lbl_RaqueteDireita.Size = new Size(16, 75);
            lbl_RaqueteDireita.TabIndex = 0;
            // 
            // pb_TempoJogo
            // 
            pb_TempoJogo.Location = new Point(48, 22);
            pb_TempoJogo.Name = "pb_TempoJogo";
            pb_TempoJogo.Size = new Size(304, 23);
            pb_TempoJogo.TabIndex = 1;
            pb_TempoJogo.Value = 100;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pb_TempoJogo);
            groupBox1.Location = new Point(159, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 57);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tempo de jogo";
            // 
            // tm_tempojogo
            // 
            tm_tempojogo.Enabled = true;
            tm_tempojogo.Interval = 1000;
            tm_tempojogo.Tick += tm_tempojogo_Tick;
            // 
            // lbl_tempo
            // 
            lbl_tempo.AutoSize = true;
            lbl_tempo.Location = new Point(331, 72);
            lbl_tempo.Name = "lbl_tempo";
            lbl_tempo.Size = new Size(60, 15);
            lbl_tempo.TabIndex = 3;
            lbl_tempo.Text = "lbl_tempo";
            // 
            // pic_bola
            // 
            pic_bola.Image = Properties.Resources.Table_tennis_ball;
            pic_bola.Location = new Point(398, 215);
            pic_bola.Name = "pic_bola";
            pic_bola.Size = new Size(32, 33);
            pic_bola.SizeMode = PictureBoxSizeMode.Zoom;
            pic_bola.TabIndex = 4;
            pic_bola.TabStop = false;
            // 
            // tm_bola
            // 
            tm_bola.Enabled = true;
            tm_bola.Interval = 30;
            tm_bola.Tick += tm_bola_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pic_bola);
            Controls.Add(lbl_tempo);
            Controls.Add(groupBox1);
            Controls.Add(lbl_RaqueteDireita);
            Controls.Add(lbl_RaqueteEsquerda);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_bola).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_RaqueteEsquerda;
        private Label lbl_RaqueteDireita;
        private ProgressBar pb_TempoJogo;
        private GroupBox groupBox1;
        private System.Windows.Forms.Timer tm_tempojogo;
        private Label lbl_tempo;
        private PictureBox pic_bola;
        private System.Windows.Forms.Timer tm_bola;
    }
}
