namespace Calculadora
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
            menuStrip1 = new MenuStrip();
            ficheiroToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            txt_valor1 = new TextBox();
            txt_valor2 = new TextBox();
            groupBox1 = new GroupBox();
            rdb_multiplicaçao = new RadioButton();
            rdb_dividir = new RadioButton();
            rdb_subtraçao = new RadioButton();
            rdb_soma = new RadioButton();
            lbl_operador = new Label();
            btn_calcular = new Button();
            lbl_resultado = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ficheiroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(289, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            ficheiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            ficheiroToolStripMenuItem.Size = new Size(61, 20);
            ficheiroToolStripMenuItem.Text = "&Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            sairToolStripMenuItem.Size = new Size(135, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // txt_valor1
            // 
            txt_valor1.Location = new Point(12, 150);
            txt_valor1.Name = "txt_valor1";
            txt_valor1.Size = new Size(100, 23);
            txt_valor1.TabIndex = 1;
            txt_valor1.TextChanged += textBox1_TextChanged;
            txt_valor1.KeyPress += txt_valor1_KeyPress;
            // 
            // txt_valor2
            // 
            txt_valor2.Location = new Point(176, 150);
            txt_valor2.Name = "txt_valor2";
            txt_valor2.Size = new Size(100, 23);
            txt_valor2.TabIndex = 2;
            txt_valor2.TextChanged += txt_valor2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_multiplicaçao);
            groupBox1.Controls.Add(rdb_dividir);
            groupBox1.Controls.Add(rdb_subtraçao);
            groupBox1.Controls.Add(rdb_soma);
            groupBox1.Location = new Point(41, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operador";
            // 
            // rdb_multiplicaçao
            // 
            rdb_multiplicaçao.AutoSize = true;
            rdb_multiplicaçao.Location = new Point(100, 44);
            rdb_multiplicaçao.Name = "rdb_multiplicaçao";
            rdb_multiplicaçao.Size = new Size(30, 19);
            rdb_multiplicaçao.TabIndex = 3;
            rdb_multiplicaçao.TabStop = true;
            rdb_multiplicaçao.Text = "*";
            rdb_multiplicaçao.UseVisualStyleBackColor = true;
            rdb_multiplicaçao.CheckedChanged += rdb_multiplicaçao_CheckedChanged;
            // 
            // rdb_dividir
            // 
            rdb_dividir.AutoSize = true;
            rdb_dividir.Location = new Point(6, 44);
            rdb_dividir.Name = "rdb_dividir";
            rdb_dividir.Size = new Size(30, 19);
            rdb_dividir.TabIndex = 2;
            rdb_dividir.TabStop = true;
            rdb_dividir.Text = "/";
            rdb_dividir.UseVisualStyleBackColor = true;
            rdb_dividir.CheckedChanged += rdb_dividir_CheckedChanged;
            // 
            // rdb_subtraçao
            // 
            rdb_subtraçao.AutoSize = true;
            rdb_subtraçao.Location = new Point(100, 22);
            rdb_subtraçao.Name = "rdb_subtraçao";
            rdb_subtraçao.Size = new Size(30, 19);
            rdb_subtraçao.TabIndex = 1;
            rdb_subtraçao.TabStop = true;
            rdb_subtraçao.Text = "-";
            rdb_subtraçao.UseVisualStyleBackColor = true;
            rdb_subtraçao.CheckedChanged += rdb_subtraçao_CheckedChanged;
            // 
            // rdb_soma
            // 
            rdb_soma.AutoSize = true;
            rdb_soma.Location = new Point(3, 19);
            rdb_soma.Name = "rdb_soma";
            rdb_soma.Size = new Size(33, 19);
            rdb_soma.TabIndex = 0;
            rdb_soma.TabStop = true;
            rdb_soma.Text = "+";
            rdb_soma.UseVisualStyleBackColor = true;
            rdb_soma.CheckedChanged += rdb_soma_CheckedChanged;
            // 
            // lbl_operador
            // 
            lbl_operador.Font = new Font("Segoe UI", 13F);
            lbl_operador.Location = new Point(118, 150);
            lbl_operador.Name = "lbl_operador";
            lbl_operador.Size = new Size(52, 23);
            lbl_operador.TabIndex = 4;
            lbl_operador.TextAlign = ContentAlignment.MiddleCenter;
            lbl_operador.Click += label1_Click;
            // 
            // btn_calcular
            // 
            btn_calcular.Enabled = false;
            btn_calcular.Location = new Point(108, 196);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(75, 23);
            btn_calcular.TabIndex = 5;
            btn_calcular.Text = "Calcular";
            btn_calcular.UseVisualStyleBackColor = true;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.Location = new Point(128, 232);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(38, 15);
            lbl_resultado.TabIndex = 6;
            lbl_resultado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 321);
            Controls.Add(lbl_resultado);
            Controls.Add(btn_calcular);
            Controls.Add(lbl_operador);
            Controls.Add(groupBox1);
            Controls.Add(txt_valor2);
            Controls.Add(txt_valor1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calculadora";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ficheiroToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private TextBox txt_valor1;
        private TextBox txt_valor2;
        private GroupBox groupBox1;
        private RadioButton rdb_multiplicaçao;
        private RadioButton rdb_dividir;
        private RadioButton rdb_subtraçao;
        private RadioButton rdb_soma;
        private Label lbl_operador;
        private Button btn_calcular;
        private Label lbl_resultado;
    }
}
