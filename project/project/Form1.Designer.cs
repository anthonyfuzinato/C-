namespace project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btn_limpar = new Button();
            lbl_JOGO = new Label();
            button8 = new Button();
            button5 = new Button();
            button2 = new Button();
            button7 = new Button();
            button4 = new Button();
            button1 = new Button();
            button6 = new Button();
            button3 = new Button();
            btn = new Button();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            lbl_adversario = new Label();
            lbl_jogador = new Label();
            lbl_empate = new Label();
            lbl_pontuaçaojogador = new Label();
            lbl_pontuaçaoadversario = new Label();
            lbl_pontuaçaoempate = new Label();
            btn_limparpontuaçao = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lbl_JOGO);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btn);
            panel1.Location = new Point(9, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 291);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_limpar);
            groupBox1.Location = new Point(327, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(159, 104);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opções";
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(24, 24);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(120, 28);
            btn_limpar.TabIndex = 1;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // lbl_JOGO
            // 
            lbl_JOGO.AutoSize = true;
            lbl_JOGO.Font = new Font("Rockwell Nova Extra Bold", 16F);
            lbl_JOGO.ForeColor = Color.Cyan;
            lbl_JOGO.Location = new Point(62, -6);
            lbl_JOGO.Name = "lbl_JOGO";
            lbl_JOGO.Size = new Size(233, 30);
            lbl_JOGO.TabIndex = 2;
            lbl_JOGO.Text = "JOGO DA VELHA";
            // 
            // button8
            // 
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button8.Location = new Point(226, 170);
            button8.Name = "button8";
            button8.Size = new Size(95, 65);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            button8.Click += btn_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button5.Location = new Point(226, 99);
            button5.Name = "button5";
            button5.Size = new Size(95, 65);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += btn_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.Location = new Point(226, 28);
            button2.Name = "button2";
            button2.Size = new Size(95, 65);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_Click;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button7.Location = new Point(125, 170);
            button7.Name = "button7";
            button7.Size = new Size(95, 65);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            button7.Click += btn_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button4.Location = new Point(125, 99);
            button4.Name = "button4";
            button4.Size = new Size(95, 65);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += btn_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.Location = new Point(125, 28);
            button1.Name = "button1";
            button1.Size = new Size(95, 65);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_Click;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button6.Location = new Point(24, 170);
            button6.Name = "button6";
            button6.Size = new Size(95, 65);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            button6.Click += btn_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button3.Location = new Point(24, 99);
            button3.Name = "button3";
            button3.Size = new Size(95, 65);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += btn_Click;
            // 
            // btn
            // 
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn.Location = new Point(24, 28);
            btn.Name = "btn";
            btn.Size = new Size(95, 65);
            btn.TabIndex = 0;
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(btn_limparpontuaçao);
            panel2.Location = new Point(12, 356);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 123);
            panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbl_adversario);
            groupBox2.Controls.Add(lbl_jogador);
            groupBox2.Controls.Add(lbl_empate);
            groupBox2.Controls.Add(lbl_pontuaçaojogador);
            groupBox2.Controls.Add(lbl_pontuaçaoadversario);
            groupBox2.Controls.Add(lbl_pontuaçaoempate);
            groupBox2.Location = new Point(6, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(466, 70);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pontuações";
            // 
            // lbl_adversario
            // 
            lbl_adversario.AutoSize = true;
            lbl_adversario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_adversario.Location = new Point(402, 40);
            lbl_adversario.Name = "lbl_adversario";
            lbl_adversario.Size = new Size(19, 21);
            lbl_adversario.TabIndex = 1;
            lbl_adversario.Text = "0";
            // 
            // lbl_jogador
            // 
            lbl_jogador.AutoSize = true;
            lbl_jogador.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_jogador.Location = new Point(48, 40);
            lbl_jogador.Name = "lbl_jogador";
            lbl_jogador.Size = new Size(19, 21);
            lbl_jogador.TabIndex = 1;
            lbl_jogador.Text = "0";
            // 
            // lbl_empate
            // 
            lbl_empate.AutoSize = true;
            lbl_empate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_empate.Location = new Point(219, 40);
            lbl_empate.Name = "lbl_empate";
            lbl_empate.Size = new Size(19, 21);
            lbl_empate.TabIndex = 1;
            lbl_empate.Text = "0";
            // 
            // lbl_pontuaçaojogador
            // 
            lbl_pontuaçaojogador.AutoSize = true;
            lbl_pontuaçaojogador.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_pontuaçaojogador.Location = new Point(16, 19);
            lbl_pontuaçaojogador.Name = "lbl_pontuaçaojogador";
            lbl_pontuaçaojogador.Size = new Size(81, 21);
            lbl_pontuaçaojogador.TabIndex = 1;
            lbl_pontuaçaojogador.Text = "Jogador1";
            // 
            // lbl_pontuaçaoadversario
            // 
            lbl_pontuaçaoadversario.AutoSize = true;
            lbl_pontuaçaoadversario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_pontuaçaoadversario.Location = new Point(370, 19);
            lbl_pontuaçaoadversario.Name = "lbl_pontuaçaoadversario";
            lbl_pontuaçaoadversario.Size = new Size(81, 21);
            lbl_pontuaçaoadversario.TabIndex = 1;
            lbl_pontuaçaoadversario.Text = "Jogador2";
            // 
            // lbl_pontuaçaoempate
            // 
            lbl_pontuaçaoempate.AutoSize = true;
            lbl_pontuaçaoempate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_pontuaçaoempate.Location = new Point(196, 19);
            lbl_pontuaçaoempate.Name = "lbl_pontuaçaoempate";
            lbl_pontuaçaoempate.Size = new Size(68, 21);
            lbl_pontuaçaoempate.TabIndex = 1;
            lbl_pontuaçaoempate.Text = "Empate";
            // 
            // btn_limparpontuaçao
            // 
            btn_limparpontuaçao.Location = new Point(181, 15);
            btn_limparpontuaçao.Name = "btn_limparpontuaçao";
            btn_limparpontuaçao.Size = new Size(120, 28);
            btn_limparpontuaçao.TabIndex = 1;
            btn_limparpontuaçao.Text = "Limpar pontuaçao ";
            btn_limparpontuaçao.UseVisualStyleBackColor = true;
            btn_limparpontuaçao.Click += btn_limparpontuaçao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(502, 481);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Jogo da velha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button btn;
        private Panel panel2;
        private Button button8;
        private Button button5;
        private Button button7;
        private Button button4;
        private Button button6;
        private Button button3;
        private Label lbl_jogador;
        private Label lbl_adversario;
        private Label lbl_empate;
        private Label lbl_pontuaçaojogador;
        private Button btn_limpar;
        private Label lbl_pontuaçaoadversario;
        private Label lbl_pontuaçaoempate;
        private Button btn_limparpontuaçao;
        private Label lbl_JOGO;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
