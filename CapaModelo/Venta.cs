using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public string TipoDocumento { get; set; }
        public string Codigo { get; set; }
        public float TotalCosto { get; set; }
        public float ImporteRecibido { get; set; }
        public float ImporteCambio { get; set; }
        public string FechaRegistro { get; set; }
        public DateTime VFechaRegistro { get; set; }
        public Usuario Usuario { get; set; }
        public Tienda Tienda { get; set; }
        public Cliente Cliente { get; set; }
        public List<DetalleVenta> ListaDetalleVenta { get; set; }

    }
}
