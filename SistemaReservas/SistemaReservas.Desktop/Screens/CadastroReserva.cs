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
        private ReservaModel? selectedReserva;
        public CadastroReserva(ReservaService service, SalaService salaService)
        {
            InitializeComponent();
            _service = service;
            _salaService = salaService;
            CarregarListaSalas();
        }

        public CadastroReserva(ReservaService service, SalaService salaService, ReservaModel reserva)
        {
            InitializeComponent();
            _service = service;
            _salaService = salaService;
            selectedReserva = reserva;
            CarregarListaSalas();

            button2.Text = "Editar";

            textNome.Text = reserva.Nome;
            dateTimeInicio.Value = reserva.Inicio;
            dateTimeFim.Value = reserva.Fim;
            listBoxSala.SelectedValue = reserva.SalaId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sucesso = false;
            var erros = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var message = "";

            if (selectedReserva == null)
            {
                var reserva = new ReservaModel
                {
                    Nome = textNome.Text,
                    Inicio = dateTimeInicio.Value.ToUniversalTime(),
                    Fim = dateTimeFim.Value.ToUniversalTime(),
                    SalaId = (long)listBoxSala.SelectedValue
                };

                sucesso = _service.Criar(reserva, out erros);
                message = "Reserva cadastrada com sucesso";
            }
            else
            {
                selectedReserva.Nome = textNome.Text;
                selectedReserva.Inicio = dateTimeInicio.Value.ToUniversalTime();
                selectedReserva.Fim = dateTimeFim.Value.ToUniversalTime();
                selectedReserva.SalaId = (long)listBoxSala.SelectedValue;
                sucesso = _service.Editar(selectedReserva, out erros);
                message = "Reserva editada com sucesso";
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

        private void CarregarListaSalas()
        {
            var salas = _salaService.Consultar();
            listBoxSala.DataSource = salas;
            listBoxSala.DisplayMember = "Nome";
            listBoxSala.ValueMember = "Id";
        }
    }
}
