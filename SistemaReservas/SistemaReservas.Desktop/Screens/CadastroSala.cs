using SistemaReservas.Models;
using SistemaReservas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaReservas.Desktop.Screens
{
    public partial class CadastroSala : Form
    {
        private readonly SalaService _service;
        public CadastroSala(SalaService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sala = new SalaModel
            {
                Nome = textNome.Text,
                Andar = (int)numericAndar.Value,
                qtdAssentos = (int)numericQtdAssentos.Value
            };

            var sucesso = _service.Criar(sala, out var erros);

            if (sucesso)
            {
                MessageBox.Show("Sala cadastrada com sucesso");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(string.Join("\n", erros.Select(e => e.ErrorMessage)), "Input Invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
