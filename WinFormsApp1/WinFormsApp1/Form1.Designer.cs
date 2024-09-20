namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            CMB_posicao = new ComboBox();
            groupBox2 = new GroupBox();
            LSB_jogadores = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            removerToolStripMenuItem = new ToolStripMenuItem();
            groupBox3 = new GroupBox();
            LSB_equipa = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CMB_posicao);
            groupBox1.Location = new Point(125, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(160, 59);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Posição";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // CMB_posicao
            // 
            CMB_posicao.FormattingEnabled = true;
            CMB_posicao.Items.AddRange(new object[] { "Guarda-Redes", "Defesa", "Médio", "Avançado" });
            CMB_posicao.Location = new Point(40, 22);
            CMB_posicao.Name = "CMB_posicao";
            CMB_posicao.Size = new Size(90, 23);
            CMB_posicao.TabIndex = 1;
            CMB_posicao.SelectedIndexChanged += CMB_posicao_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LSB_jogadores);
            groupBox2.Location = new Point(125, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 229);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Jogadores";
            // 
            // LSB_jogadores
            // 
            LSB_jogadores.ContextMenuStrip = contextMenuStrip1;
            LSB_jogadores.Enabled = false;
            LSB_jogadores.FormattingEnabled = true;
            LSB_jogadores.ItemHeight = 15;
            LSB_jogadores.Location = new Point(30, 22);
            LSB_jogadores.Name = "LSB_jogadores";
            LSB_jogadores.Size = new Size(120, 184);
            LSB_jogadores.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, removerToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(126, 48);
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(125, 22);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.Size = new Size(125, 22);
            removerToolStripMenuItem.Text = "Remover";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(LSB_equipa);
            groupBox3.Location = new Point(436, 54);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 314);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Equipa";
            // 
            // LSB_equipa
            // 
            LSB_equipa.FormattingEnabled = true;
            LSB_equipa.ItemHeight = 15;
            LSB_equipa.Location = new Point(29, 22);
            LSB_equipa.Name = "LSB_equipa";
            LSB_equipa.Size = new Size(142, 274);
            LSB_equipa.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Seleção Nacional de Futebol";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox CMB_posicao;
        private GroupBox groupBox2;
        private ListBox LSB_jogadores;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem removerToolStripMenuItem;
        private GroupBox groupBox3;
        private ListBox LSB_equipa;
    }
}
