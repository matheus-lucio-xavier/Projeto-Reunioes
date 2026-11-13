using SistemaReservas.Models;
using SistemaReservas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaReservas.Desktop.Screens
{
    public partial class CadastroSala : Form
    {
        private readonly SalaService _service;
        private SalaModel? selectedSala;
        public CadastroSala(SalaService service)
        {
            InitializeComponent();
            _service = service;
        }

        public CadastroSala(SalaService service, SalaModel sala)
        {
            InitializeComponent();
            _service = service;
            selectedSala = sala;

            button2.Text = "Editar";

            textNome.Text = sala.Nome;
            numericAndar.Value = sala.Andar;
            numericQtdAssentos.Value = sala.qtdAssentos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sucesso = false;
            var erros = new List<ValidationResult>();
            var message = "";
            if (selectedSala == null)
            {
                var sala = new SalaModel
                {
                    Nome = textNome.Text,
                    Andar = (int)numericAndar.Value,
                    qtdAssentos = (int)numericQtdAssentos.Value
                };

                sucesso = _service.Criar(sala, out erros);
                message = "Sala cadastrada com sucesso";
            }
            else
            {

                selectedSala.Nome = textNome.Text;
                selectedSala.Andar = (int)numericAndar.Value;
                selectedSala.qtdAssentos = (int)numericQtdAssentos.Value;

                sucesso = _service.Editar(selectedSala, out erros);
                message = "Sala editada com sucesso";
            }

            if (sucesso)
            {
                MessageBox.Show(message);
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
