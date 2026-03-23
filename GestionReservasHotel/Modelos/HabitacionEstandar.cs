using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionReservasHotel.Modelos
{
    public class HabitacionEstandar : Reserva
    {
        public override decimal CalcularCostoTotal()
        {
            return base.CalcularCostoTotal();
        }
    }
}
