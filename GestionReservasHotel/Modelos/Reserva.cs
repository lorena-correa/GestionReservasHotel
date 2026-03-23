using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservasHotel.Modelos
{
    internal class Reserva
    {
        public string NombreCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public int NumeroHabitacion { get; set; }
        public DateTime FechaReserva { get; set; }
        public int DuracionEstadia { get; set; }
        public decimal TarifaPorNoche { get; set; }

        public virtual decimal CalcularCostoTotal()
        {
            return TarifaPorNoche * DuracionEstadia;
        }


    }
}
