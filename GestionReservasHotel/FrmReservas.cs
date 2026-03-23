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

        }
    }
}
