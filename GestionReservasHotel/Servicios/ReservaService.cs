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

    }
}
