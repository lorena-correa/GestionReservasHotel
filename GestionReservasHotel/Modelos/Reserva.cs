using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservasHotel.Modelos
{
    public class Reserva
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
        public virtual void ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(NombreCliente))
                throw new Exception("El nombre del cliente es obligatorio");

            if (NumeroHabitacion <= 0)
                throw new Exception("Número de habitación inválido");

            if (DuracionEstadia <= 1)
                throw new Exception("La duración debe ser mayor a 1 noche");

            if (TarifaPorNoche <= 0)
                throw new Exception("La tarifa debe ser mayor a 0");
        }

    }
}
