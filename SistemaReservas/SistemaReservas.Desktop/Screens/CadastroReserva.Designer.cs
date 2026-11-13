namespace SistemaReservas.Desktop.Screens
{
    partial class CadastroReserva
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
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Location = new Point(483, 361);
            button2.Name = "button2";
            button2.Size = new Size(98, 40);
            button2.TabIndex = 15;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Location = new Point(379, 361);
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
            label3.Size = new Size(36, 15);
            label3.TabIndex = 13;
            label3.Text = "Inicio";
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
            label1.Size = new Size(27, 15);
            label1.TabIndex = 11;
            label1.Text = "Fim";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 23);
            textBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Location = new Point(219, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(362, 23);
            dateTimePicker1.TabIndex = 16;
            dateTimePicker1.Value = new DateTime(2026, 11, 13, 12, 50, 56, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker2.Location = new Point(219, 246);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(362, 23);
            dateTimePicker2.TabIndex = 17;
            dateTimePicker2.Value = new DateTime(2026, 11, 13, 12, 35, 37, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 284);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 18;
            label4.Text = "Sala";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(219, 302);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(362, 19);
            listBox1.TabIndex = 19;
            // 
            // CadastroReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "CadastroReserva";
            Text = "CadastroReserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private ListBox listBox1;
    }
}