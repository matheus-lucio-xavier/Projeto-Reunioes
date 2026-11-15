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

            dateTimeInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            dateTimeFim.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
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
            comboBoxSala.SelectedValue = reserva.SalaId;
        }

        private void CarregarListaSalas()
        {
            var salas = _salaService.Consultar();

            comboBoxSala.DataSource = null;

            comboBoxSala.DisplayMember = "Nome";
            comboBoxSala.ValueMember = "Id";

            comboBoxSala.DataSource = salas;
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
                var dateInicio = new DateTime(dateTimeInicio.Value.Year, dateTimeInicio.Value.Month, dateTimeInicio.Value.Day, dateTimeInicio.Value.Hour, dateTimeInicio.Value.Minute, 0);
                var dateFim = new DateTime(dateTimeFim.Value.Year, dateTimeFim.Value.Month, dateTimeFim.Value.Day, dateTimeFim.Value.Hour, dateTimeFim.Value.Minute, 0);

                var reserva = new ReservaModel
                {
                    Nome = textNome.Text,
                    Inicio = dateInicio.ToUniversalTime(),
                    Fim = dateFim.ToUniversalTime(),
                    SalaId = (long)comboBoxSala.SelectedValue
                };

                sucesso = _service.Criar(reserva, out erros);
                message = "Reserva cadastrada com sucesso";
            }
            else
            {
                var dateInicio = new DateTime(dateTimeInicio.Value.Year, dateTimeInicio.Value.Month, dateTimeInicio.Value.Day, dateTimeInicio.Value.Hour, dateTimeInicio.Value.Minute, 0);
                var dateFim = new DateTime(dateTimeFim.Value.Year, dateTimeFim.Value.Month, dateTimeFim.Value.Day, dateTimeFim.Value.Hour, dateTimeFim.Value.Minute, 0);

                selectedReserva.Nome = textNome.Text;
                selectedReserva.Inicio = dateInicio.ToUniversalTime();
                selectedReserva.Fim = dateFim.ToUniversalTime();
                selectedReserva.SalaId = (long)comboBoxSala.SelectedValue;
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
    }
}
