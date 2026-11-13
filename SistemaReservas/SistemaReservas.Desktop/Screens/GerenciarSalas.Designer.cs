namespace SistemaReservas.Desktop.Screens
{
    partial class GerenciarSalas
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
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Andar = new DataGridViewTextBoxColumn();
            QuantidadeAssentos = new DataGridViewTextBoxColumn();
            HorasLivres = new DataGridViewTextBoxColumn();
            ReunioesAgendadas = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Andar, QuantidadeAssentos, HorasLivres, ReunioesAgendadas });
            dataGridView1.Location = new Point(32, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(743, 320);
            dataGridView1.TabIndex = 0;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Resizable = DataGridViewTriState.False;
            Nome.SortMode = DataGridViewColumnSortMode.NotSortable;
            Nome.Width = 75;
            // 
            // Andar
            // 
            Andar.HeaderText = "Andar";
            Andar.Name = "Andar";
            Andar.ReadOnly = true;
            Andar.Resizable = DataGridViewTriState.False;
            Andar.SortMode = DataGridViewColumnSortMode.NotSortable;
            Andar.Width = 75;
            // 
            // QuantidadeAssentos
            // 
            QuantidadeAssentos.HeaderText = "Quantidade de Assentos";
            QuantidadeAssentos.Name = "QuantidadeAssentos";
            QuantidadeAssentos.ReadOnly = true;
            QuantidadeAssentos.Resizable = DataGridViewTriState.False;
            QuantidadeAssentos.SortMode = DataGridViewColumnSortMode.NotSortable;
            QuantidadeAssentos.Width = 175;
            // 
            // HorasLivres
            // 
            HorasLivres.HeaderText = "Horas Livres (Ultimos 7 dias)";
            HorasLivres.Name = "HorasLivres";
            HorasLivres.ReadOnly = true;
            HorasLivres.Resizable = DataGridViewTriState.False;
            HorasLivres.SortMode = DataGridViewColumnSortMode.NotSortable;
            HorasLivres.Width = 175;
            // 
            // ReunioesAgendadas
            // 
            ReunioesAgendadas.HeaderText = "Reunioes Agendadas (Ultimos 7 dias)";
            ReunioesAgendadas.Name = "ReunioesAgendadas";
            ReunioesAgendadas.ReadOnly = true;
            ReunioesAgendadas.Resizable = DataGridViewTriState.False;
            ReunioesAgendadas.SortMode = DataGridViewColumnSortMode.NotSortable;
            ReunioesAgendadas.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 23);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.TabIndex = 1;
            label1.Text = "Salas";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(664, 26);
            button1.Name = "button1";
            button1.Size = new Size(111, 33);
            button1.TabIndex = 2;
            button1.Text = "Cadastrar Sala";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "\r\n";
            // 
            // button2
            // 
            button2.Location = new Point(532, 36);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Pesquisa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(673, 391);
            button3.Name = "button3";
            button3.Size = new Size(102, 33);
            button3.TabIndex = 5;
            button3.Text = "Excluir Sala";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(565, 391);
            button4.Name = "button4";
            button4.Size = new Size(102, 33);
            button4.TabIndex = 6;
            button4.Text = "Editar Sala";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Location = new Point(42, 399);
            button5.Name = "button5";
            button5.Size = new Size(24, 23);
            button5.TabIndex = 8;
            button5.Text = "<";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(98, 399);
            button6.Name = "button6";
            button6.Size = new Size(24, 23);
            button6.TabIndex = 9;
            button6.Text = ">";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(72, 399);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(20, 23);
            maskedTextBox1.TabIndex = 10;
            maskedTextBox1.TextChanged += MaskedTextBox1_TextChanged;
            maskedTextBox1.KeyPress += MaskedTextBox1_KeyPress;
            // 
            // GerenciarSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "GerenciarSalas";
            Text = "Gerenciar Salas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private MaskedTextBox maskedTextBox1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Andar;
        private DataGridViewTextBoxColumn QuantidadeAssentos;
        private DataGridViewTextBoxColumn HorasLivres;
        private DataGridViewTextBoxColumn ReunioesAgendadas;
    }
}