using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public string Codigo { get; set; }
        public string FechaCompra { get; set; }
        public string NumeroCompra { get; set; }
        public Usuario Usuario { get; set; }
        public Proveedor Proveedor { get; set; }
        public Tienda Tienda { get; set; }
        public List<DetalleCompra> ListaDetalleCompra { get; set; }
        public float TotalCosto { get; set; }
        public string TipoComprobante { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
