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
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Inicio = new DataGridViewTextBoxColumn();
            Fim = new DataGridViewTextBoxColumn();
            Sala = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            button2 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(659, 26);
            button1.Name = "button1";
            button1.Size = new Size(114, 33);
            button1.TabIndex = 5;
            button1.Text = "Cadastrar Reserva";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 4;
            label1.Text = "Reservas";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Inicio, Fim, Sala, Status });
            dataGridView1.Location = new Point(139, 75);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(555, 320);
            dataGridView1.TabIndex = 3;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
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
            button2.Location = new Point(547, 46);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Pesquisa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 23);
            textBox1.TabIndex = 8;
            textBox1.Text = "\r\n";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(531, 401);
            button4.Name = "button4";
            button4.Size = new Size(119, 33);
            button4.TabIndex = 10;
            button4.Text = "Editar Reserva";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(656, 401);
            button3.Name = "button3";
            button3.Size = new Size(117, 33);
            button3.TabIndex = 9;
            button3.Text = "Cancelar Reserva";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Location = new Point(195, 401);
            button6.Name = "button6";
            button6.Size = new Size(24, 23);
            button6.TabIndex = 13;
            button6.Text = ">";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(139, 401);
            button5.Name = "button5";
            button5.Size = new Size(24, 23);
            button5.TabIndex = 12;
            button5.Text = "<";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(169, 401);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(20, 23);
            maskedTextBox1.TabIndex = 14;
            maskedTextBox1.TextChanged += MaskedTextBox1_TextChanged;
            maskedTextBox1.KeyPress += MaskedTextBox1_KeyPress;
            // 
            // GerenciarReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(maskedTextBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
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
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button5;
        private MaskedTextBox maskedTextBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Inicio;
        private DataGridViewTextBoxColumn Fim;
        private DataGridViewTextBoxColumn Sala;
        private DataGridViewTextBoxColumn Status;
    }
}