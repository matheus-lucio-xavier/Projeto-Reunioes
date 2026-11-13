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
            textNome = new TextBox();
            dateTimeInicio = new DateTimePicker();
            dateTimeFim = new DateTimePicker();
            label4 = new Label();
            listBoxSala = new ListBox();
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
            button2.Click += button2_Click;
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
            // textNome
            // 
            textNome.Location = new Point(219, 128);
            textNome.Name = "textNome";
            textNome.Size = new Size(362, 23);
            textNome.TabIndex = 8;
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimeInicio.Format = DateTimePickerFormat.Custom;
            dateTimeInicio.Location = new Point(219, 190);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(362, 23);
            dateTimeInicio.TabIndex = 16;
            dateTimeInicio.Value = new DateTime(2026, 11, 13, 12, 50, 56, 0);
            // 
            // dateTimeFim
            // 
            dateTimeFim.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimeFim.Format = DateTimePickerFormat.Custom;
            dateTimeFim.Location = new Point(219, 246);
            dateTimeFim.Name = "dateTimeFim";
            dateTimeFim.Size = new Size(362, 23);
            dateTimeFim.TabIndex = 17;
            dateTimeFim.Value = new DateTime(2026, 11, 13, 12, 35, 37, 0);
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
            // listBoxSala
            // 
            listBoxSala.FormattingEnabled = true;
            listBoxSala.Location = new Point(219, 302);
            listBoxSala.Name = "listBoxSala";
            listBoxSala.Size = new Size(362, 19);
            listBoxSala.TabIndex = 19;
            // 
            // CadastroReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxSala);
            Controls.Add(label4);
            Controls.Add(dateTimeFim);
            Controls.Add(dateTimeInicio);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textNome);
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
        private TextBox textNome;
        private DateTimePicker dateTimeInicio;
        private DateTimePicker dateTimeFim;
        private Label label4;
        private ListBox listBoxSala;
    }
}