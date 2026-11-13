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
    public partial class CadastroReserva : Form
    {
        private readonly ReservaService _service;
        private readonly SalaService _salaService;
        public CadastroReserva(ReservaService service, SalaService salaService)
        {
            InitializeComponent();
            _service = service;
            _salaService = salaService;
            CarregarListaSalas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var reserva = new ReservaModel
            {
                Nome = textNome.Text,
                Inicio = dateTimeInicio.Value.ToUniversalTime(),
                Fim = dateTimeFim.Value.ToUniversalTime(),
                SalaId = (long)listBoxSala.SelectedValue
            };

            var sucesso = _service.Criar(reserva, out var erros);

            if (sucesso)
            {
                MessageBox.Show("Reserva cadastrada com sucesso");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(string.Join("\n", erros.Select(e => e.ErrorMessage)), "Input Invalido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CarregarListaSalas()
        {
            var salas = _salaService.Consultar();
            listBoxSala.DataSource = salas;
            listBoxSala.DisplayMember = "Nome";
            listBoxSala.ValueMember = "Id";
        }
    }
}
