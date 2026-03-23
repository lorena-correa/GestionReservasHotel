using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservasHotel.Modelos
{
    public class HabitacionVIP : Reserva
    {
        public override decimal CalcularCostoTotal()
        {
            decimal total = base.CalcularCostoTotal();

            if (DuracionEstadia > 5)
                total *= 0.8m;

            return total;
        }
    }
}