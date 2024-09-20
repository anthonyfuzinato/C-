namespace Quizz_Python
{
    partial class Quizz_Python
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
            lbl_Pergunta = new Label();
            rdb_resposta1 = new RadioButton();
            rdb_resposta2 = new RadioButton();
            rdb_resposta3 = new RadioButton();
            rdb_resposta4 = new RadioButton();
            btn_Ok = new Button();
            SuspendLayout();
            // 
            // lbl_Pergunta
            // 
            lbl_Pergunta.Location = new Point(153, 60);
            lbl_Pergunta.Name = "lbl_Pergunta";
            lbl_Pergunta.Size = new Size(560, 51);
            lbl_Pergunta.TabIndex = 0;
            lbl_Pergunta.Text = "label1";
            // 
            // rdb_resposta1
            // 
            rdb_resposta1.AutoSize = true;
            rdb_resposta1.Location = new Point(153, 135);
            rdb_resposta1.Name = "rdb_resposta1";
            rdb_resposta1.Size = new Size(94, 19);
            rdb_resposta1.TabIndex = 1;
            rdb_resposta1.TabStop = true;
            rdb_resposta1.Text = "radioButton1";
            rdb_resposta1.UseVisualStyleBackColor = true;
            rdb_resposta1.CheckedChanged += rdb_resposta1_CheckedChanged;
            // 
            // rdb_resposta2
            // 
            rdb_resposta2.AutoSize = true;
            rdb_resposta2.Location = new Point(153, 160);
            rdb_resposta2.Name = "rdb_resposta2";
            rdb_resposta2.Size = new Size(94, 19);
            rdb_resposta2.TabIndex = 2;
            rdb_resposta2.TabStop = true;
            rdb_resposta2.Text = "radioButton2";
            rdb_resposta2.UseVisualStyleBackColor = true;
            rdb_resposta2.CheckedChanged += rdb_resposta2_CheckedChanged;
            // 
            // rdb_resposta3
            // 
            rdb_resposta3.AutoSize = true;
            rdb_resposta3.Location = new Point(153, 185);
            rdb_resposta3.Name = "rdb_resposta3";
            rdb_resposta3.Size = new Size(94, 19);
            rdb_resposta3.TabIndex = 2;
            rdb_resposta3.TabStop = true;
            rdb_resposta3.Text = "radioButton2";
            rdb_resposta3.UseVisualStyleBackColor = true;
            rdb_resposta3.CheckedChanged += rdb_resposta3_CheckedChanged;
            // 
            // rdb_resposta4
            // 
            rdb_resposta4.AutoSize = true;
            rdb_resposta4.Location = new Point(153, 210);
            rdb_resposta4.Name = "rdb_resposta4";
            rdb_resposta4.Size = new Size(94, 19);
            rdb_resposta4.TabIndex = 2;
            rdb_resposta4.TabStop = true;
            rdb_resposta4.Text = "radioButton2";
            rdb_resposta4.UseVisualStyleBackColor = true;
            rdb_resposta4.CheckedChanged += rdb_resposta4_CheckedChanged;
            // 
            // btn_Ok
            // 
            btn_Ok.Location = new Point(159, 239);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(75, 23);
            btn_Ok.TabIndex = 3;
            btn_Ok.Text = "Ok";
            btn_Ok.UseVisualStyleBackColor = true;
            btn_Ok.Click += btn_Ok_Click;
            // 
            // Quizz_Python
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 316);
            Controls.Add(btn_Ok);
            Controls.Add(rdb_resposta4);
            Controls.Add(rdb_resposta3);
            Controls.Add(rdb_resposta2);
            Controls.Add(rdb_resposta1);
            Controls.Add(lbl_Pergunta);
            Name = "Quizz_Python";
            Text = "Quizz sobre Python";
            Load += Quizz_Python_Load;
            Resize += Quizz__Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Pergunta;
        private RadioButton rdb_resposta1;
        private RadioButton rdb_resposta2;
        private RadioButton rdb_resposta3;
        private RadioButton rdb_resposta4;
        private Button btn_Ok;
    }
}
