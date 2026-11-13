namespace SistemaReservas.Desktop.Screens
{
    partial class CadastroSala
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericQtdAssentos = new NumericUpDown();
            numericAndar = new NumericUpDown();
            textNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericQtdAssentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericAndar).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(483, 300);
            button2.Name = "button2";
            button2.Size = new Size(98, 40);
            button2.TabIndex = 15;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(379, 300);
            button1.Name = "button1";
            button1.Size = new Size(98, 40);
            button1.TabIndex = 14;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 172);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 13;
            label3.Text = "Andar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 110);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 12;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 228);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 11;
            label1.Text = "Quantidade de Assentos";
            // 
            // numericQtdAssentos
            // 
            numericQtdAssentos.Location = new Point(219, 246);
            numericQtdAssentos.Name = "numericQtdAssentos";
            numericQtdAssentos.Size = new Size(362, 23);
            numericQtdAssentos.TabIndex = 10;
            numericQtdAssentos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericAndar
            // 
            numericAndar.Location = new Point(219, 190);
            numericAndar.Name = "numericAndar";
            numericAndar.Size = new Size(362, 23);
            numericAndar.TabIndex = 9;
            numericAndar.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textNome
            // 
            textNome.Location = new Point(219, 128);
            textNome.Name = "textNome";
            textNome.Size = new Size(362, 23);
            textNome.TabIndex = 8;
            // 
            // CadastroSala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericQtdAssentos);
            Controls.Add(numericAndar);
            Controls.Add(textNome);
            Name = "CadastroSala";
            Text = "CadastroSala";
            ((System.ComponentModel.ISupportInitialize)numericQtdAssentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericAndar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericQtdAssentos;
        private NumericUpDown numericAndar;
        private TextBox textNome;
    }
}