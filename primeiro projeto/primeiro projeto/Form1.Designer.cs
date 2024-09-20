namespace primeiro_projeto
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
            lbl = new Label();
            label2 = new Label();
            btn = new Button();
            btn_nao1 = new Button();
            btn_nao2 = new Button();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 14F);
            lbl.ForeColor = Color.Red;
            lbl.Location = new Point(295, 179);
            lbl.Name = "lbl";
            lbl.Size = new Size(208, 25);
            lbl.TabIndex = 0;
            lbl.Text = "Quer namorar comigo?";
            lbl.Click += lbl_Click;
            lbl.DoubleClick += lbl_mensagem;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 98);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // btn
            // 
            btn.Location = new Point(316, 222);
            btn.Name = "btn";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 2;
            btn.Tag = "Autor";
            btn.Text = "Sim";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // btn_nao1
            // 
            btn_nao1.Location = new Point(428, 222);
            btn_nao1.Name = "btn_nao1";
            btn_nao1.Size = new Size(75, 23);
            btn_nao1.TabIndex = 3;
            btn_nao1.Tag = "Autor";
            btn_nao1.Text = "Nao";
            btn_nao1.UseVisualStyleBackColor = true;
            btn_nao1.MouseMove += btn_nao1_MouseMove;
            // 
            // btn_nao2
            // 
            btn_nao2.Location = new Point(190, 170);
            btn_nao2.Name = "btn_nao2";
            btn_nao2.Size = new Size(75, 23);
            btn_nao2.TabIndex = 4;
            btn_nao2.Tag = "Autor";
            btn_nao2.Text = "Nao";
            btn_nao2.UseVisualStyleBackColor = true;
            btn_nao2.Visible = false;
            btn_nao2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_nao2);
            Controls.Add(btn_nao1);
            Controls.Add(btn);
            Controls.Add(label2);
            Controls.Add(lbl);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Primeiro progama em C#";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Label label2;
        private Button btn;
        private Button btn_nao1;
        private Button btn_nao2;
    }
}
