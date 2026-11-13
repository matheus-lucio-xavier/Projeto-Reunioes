namespace SistemaReservas.Desktop.Screens
{
    partial class GerenciarReservas
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
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Inicio = new DataGridViewTextBoxColumn();
            Fim = new DataGridViewTextBoxColumn();
            Sala = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            button2 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(659, 83);
            button1.Name = "button1";
            button1.Size = new Size(114, 33);
            button1.TabIndex = 5;
            button1.Text = "Cadastrar Reserva";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 83);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 4;
            label1.Text = "Reservas";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Inicio, Fim, Sala, Status });
            dataGridView1.Location = new Point(139, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(543, 264);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Resizable = DataGridViewTriState.False;
            Nome.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Inicio
            // 
            Inicio.HeaderText = "Inicio";
            Inicio.Name = "Inicio";
            Inicio.ReadOnly = true;
            Inicio.Resizable = DataGridViewTriState.False;
            Inicio.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Fim
            // 
            Fim.HeaderText = "Fim";
            Fim.Name = "Fim";
            Fim.ReadOnly = true;
            Fim.Resizable = DataGridViewTriState.False;
            Fim.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Sala
            // 
            Sala.HeaderText = "Sala";
            Sala.Name = "Sala";
            Sala.ReadOnly = true;
            Sala.Resizable = DataGridViewTriState.False;
            Sala.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Resizable = DataGridViewTriState.False;
            Status.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // button2
            // 
            button2.Location = new Point(547, 103);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Pesquisa";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 23);
            textBox1.TabIndex = 8;
            textBox1.Text = "\r\n";
            // 
            // GerenciarReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "GerenciarReservas";
            Text = "Gerenciar Reservas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Inicio;
        private DataGridViewTextBoxColumn Fim;
        private DataGridViewTextBoxColumn Sala;
        private DataGridViewTextBoxColumn Status;
    }
}