using GestionReservasHotel.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservasHotel.Servicios
{
    internal class ReservaService{
        private List<Reserva> reservas = new List<Reserva>();

        public List<Reserva> ObtenerTodas()
        {
            return reservas;
        }

        public void Agregar(Reserva nueva)
        {
            nueva.ValidarDatos();

            if (ExisteConflicto(nueva))
                throw new Exception("Conflicto: habitación ya reservada en esas fechas");

            reservas.Add(nueva);
        }

        public void Eliminar(int numeroHabitacion)
        {
            var reserva = reservas.FirstOrDefault(r => r.NumeroHabitacion == numeroHabitacion);

            if (reserva == null)
                throw new Exception("Reserva no encontrada");

            reservas.Remove(reserva);
        }

        private bool ExisteConflicto(Reserva nueva)
        {
            return reservas.Any(r =>
                r.NumeroHabitacion == nueva.NumeroHabitacion &&
                r.FechaReserva <= nueva.FechaReserva.AddDays(nueva.DuracionEstadia) &&
                nueva.FechaReserva <= r.FechaReserva.AddDays(r.DuracionEstadia)
            );
        }

    }
}
