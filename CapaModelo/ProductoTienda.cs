﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class ProductoTienda
    {
        public int IdProductoTienda { get; set; }
        public Producto Producto { get; set; }
        public Tienda Tienda { get; set; }
        public float Stock { get; set; }
        public float PrecioUnidadCompra { get; set; }
        public float PrecioUnidadVenta { get; set; }
        public bool Iniciado { get; set; }
    }
}
