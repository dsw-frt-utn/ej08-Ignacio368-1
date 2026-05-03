using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Helpers
{
    public static partial class ProductHelper
    {
        public static string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            return $"[{code}] {description}{Separador}{price.ToString("C")}";
        }
    }
}

