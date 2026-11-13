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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Andar, QuantidadeAssentos, HorasLivres, ReunioesAgendadas });
            dataGridView1.Location = new Point(32, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(743, 264);
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
            label1.Location = new Point(32, 82);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.TabIndex = 1;
            label1.Text = "Salas";
            // 
            // button1
            // 
            button1.Location = new Point(673, 82);
            button1.Name = "button1";
            button1.Size = new Size(102, 33);
            button1.TabIndex = 2;
            button1.Text = "Cadastrar Sala";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "\r\n";
            // 
            // button2
            // 
            button2.Location = new Point(532, 92);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Pesquisa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // GerenciarSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Andar;
        private DataGridViewTextBoxColumn QuantidadeAssentos;
        private DataGridViewTextBoxColumn HorasLivres;
        private DataGridViewTextBoxColumn ReunioesAgendadas;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
    }
}