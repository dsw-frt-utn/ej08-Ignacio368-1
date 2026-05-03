using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Problema6
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (code == null)
                return "SIN-CODIGO";

            string resultado = code.Trim(); // elimina espacios inicio y fin
            resultado = resultado.ToUpper(); // mayúsculas
            resultado = resultado.Replace(" ", "-"); // espacios → guiones

            return resultado;
        }
    }
}
