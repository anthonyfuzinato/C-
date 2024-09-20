namespace app_misturador
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
            HSC_vermelho = new HScrollBar();
            lbl_vermelho = new Label();
            lbl_Azul = new Label();
            HSC_Azul = new HScrollBar();
            lbl_Verde = new Label();
            HSC_Verde = new HScrollBar();
            SuspendLayout();
            // 
            // HSC_vermelho
            // 
            HSC_vermelho.Location = new Point(74, 168);
            HSC_vermelho.Maximum = 264;
            HSC_vermelho.Name = "HSC_vermelho";
            HSC_vermelho.Size = new Size(621, 19);
            HSC_vermelho.TabIndex = 0;
            HSC_vermelho.Scroll += HSC_vermelho_Scroll;
            // 
            // lbl_vermelho
            // 
            lbl_vermelho.AutoSize = true;
            lbl_vermelho.Font = new Font("Segoe UI", 12F);
            lbl_vermelho.ForeColor = Color.Red;
            lbl_vermelho.Location = new Point(699, 166);
            lbl_vermelho.Name = "lbl_vermelho";
            lbl_vermelho.Size = new Size(19, 21);
            lbl_vermelho.TabIndex = 1;
            lbl_vermelho.Text = "0";
            lbl_vermelho.TextAlign = ContentAlignment.MiddleCenter;
            lbl_vermelho.Click += lbl_vermelho_Click;
            // 
            // lbl_Azul
            // 
            lbl_Azul.AutoSize = true;
            lbl_Azul.Font = new Font("Segoe UI", 12F);
            lbl_Azul.ForeColor = Color.Blue;
            lbl_Azul.Location = new Point(699, 311);
            lbl_Azul.Name = "lbl_Azul";
            lbl_Azul.Size = new Size(19, 21);
            lbl_Azul.TabIndex = 3;
            lbl_Azul.Text = "0";
            lbl_Azul.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Azul.Click += lbl_Azul_Click;
            // 
            // HSC_Azul
            // 
            HSC_Azul.Location = new Point(74, 314);
            HSC_Azul.Maximum = 264;
            HSC_Azul.Name = "HSC_Azul";
            HSC_Azul.Size = new Size(621, 19);
            HSC_Azul.TabIndex = 2;
            HSC_Azul.Scroll += HSC_Azul_Scroll;
            // 
            // lbl_Verde
            // 
            lbl_Verde.AutoSize = true;
            lbl_Verde.Font = new Font("Segoe UI", 12F);
            lbl_Verde.ForeColor = Color.Lime;
            lbl_Verde.Location = new Point(699, 235);
            lbl_Verde.Name = "lbl_Verde";
            lbl_Verde.Size = new Size(19, 21);
            lbl_Verde.TabIndex = 5;
            lbl_Verde.Text = "0";
            lbl_Verde.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HSC_Verde
            // 
            HSC_Verde.Location = new Point(72, 237);
            HSC_Verde.Maximum = 264;
            HSC_Verde.Name = "HSC_Verde";
            HSC_Verde.Size = new Size(621, 19);
            HSC_Verde.TabIndex = 4;
            HSC_Verde.Scroll += HSC_Verde_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Verde);
            Controls.Add(HSC_Verde);
            Controls.Add(lbl_Azul);
            Controls.Add(HSC_Azul);
            Controls.Add(lbl_vermelho);
            Controls.Add(HSC_vermelho);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HScrollBar HSC_vermelho;
        private Label lbl_vermelho;
        private Label lbl_Azul;
        private HScrollBar HSC_Azul;
        private Label lbl_Verde;
        private HScrollBar HSC_Verde;
    }
}
