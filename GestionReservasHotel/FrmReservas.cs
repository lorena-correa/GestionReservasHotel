using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionReservasHotel.Modelos;
using GestionReservasHotel.Servicios;

namespace GestionReservasHotel
{
    public partial class FrmReservas : Form
    {
        private ReservaService servicio = new ReservaService();
        public FrmReservas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoHabitacion.SelectedItem == null)
                    throw new Exception("Seleccione un tipo de habitación");

                Reserva reserva;

                if (cmbTipoHabitacion.SelectedItem.ToString() == "VIP")
                    reserva = new HabitacionVIP();
                else
                    reserva = new HabitacionEstandar();

                if (cmbTipoHabitacion.SelectedItem.ToString() == "VIP")
                {
                    reserva = new HabitacionVIP();
                    reserva.TipoHabitacion = "VIP";
                }
                else
                {
                    reserva = new HabitacionEstandar();
                    reserva.TipoHabitacion = "Estandar";
                }

                reserva.NombreCliente = txtNombreCliente.Text;
                reserva.DocumentoCliente = txtDocumento.Text;
                reserva.NumeroHabitacion = int.Parse(txtNumeroHabitacion.Text);
                reserva.FechaReserva = dtpFechaReserva.Value;
                reserva.DuracionEstadia = int.Parse(txtDuracion.Text);
                reserva.TarifaPorNoche = decimal.Parse(txtTarifa.Text);

                servicio.Agregar(reserva);

                MessageBox.Show("Reserva agregada correctamente");

                ActualizarTabla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ActualizarTabla()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = servicio.ObtenerTodas();
        }
        //Limpiar todos los campos
        private void LimpiarCampos()
        {
            txtNombreCliente.Clear();
            txtDocumento.Clear();
            txtNumeroHabitacion.Clear();
            txtDuracion.Clear();
            txtTarifa.Clear();
            txtObservaciones.Clear();
            cmbTipoHabitacion.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservas.CurrentRow == null)
                    throw new Exception("Seleccione una reserva");

                int numeroHabitacion = Convert.ToInt32(dgvReservas.CurrentRow.Cells["NumeroHabitacion"].Value);

                servicio.Eliminar(numeroHabitacion);

                MessageBox.Show("Reserva eliminada");

                ActualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {
                txtNombreCliente.Text = dgvReservas.CurrentRow.Cells["NombreCliente"].Value?.ToString();
                txtDocumento.Text = dgvReservas.CurrentRow.Cells["DocumentoCliente"].Value?.ToString();
                txtNumeroHabitacion.Text = dgvReservas.CurrentRow.Cells["NumeroHabitacion"].Value?.ToString();
                txtDuracion.Text = dgvReservas.CurrentRow.Cells["DuracionEstadia"].Value?.ToString();
                txtTarifa.Text = dgvReservas.CurrentRow.Cells["TarifaPorNoche"].Value?.ToString();

                var tipo = dgvReservas.CurrentRow.Cells["TipoHabitacion"].Value;

                if (tipo != null)
                    cmbTipoHabitacion.SelectedItem = tipo.ToString();
                else
                    cmbTipoHabitacion.SelectedIndex = -1;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservas.CurrentRow == null)
                    throw new Exception("Seleccione una reserva");

                if (cmbTipoHabitacion.SelectedItem == null)
                    throw new Exception("Seleccione un tipo de habitación");

                Reserva reserva;

                if (cmbTipoHabitacion.SelectedItem.ToString() == "VIP")
                {
                    reserva = new HabitacionVIP();
                    reserva.TipoHabitacion = "VIP";
                }
                else
                {
                    reserva = new HabitacionEstandar();
                    reserva.TipoHabitacion = "Estandar";
                }

                reserva.NombreCliente = txtNombreCliente.Text;
                reserva.DocumentoCliente = txtDocumento.Text;
                reserva.NumeroHabitacion = int.Parse(txtNumeroHabitacion.Text);
                reserva.FechaReserva = dtpFechaReserva.Value;
                reserva.DuracionEstadia = int.Parse(txtDuracion.Text);
                reserva.TarifaPorNoche = decimal.Parse(txtTarifa.Text);

                //Elimina ell viejo
                int numeroOriginal = Convert.ToInt32(dgvReservas.CurrentRow.Cells["NumeroHabitacion"].Value);
                servicio.Eliminar(numeroOriginal);

                //Agrega lo nuevo editado
                servicio.Agregar(reserva); 

                MessageBox.Show("Reserva editada correctamente");

                ActualizarTabla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
