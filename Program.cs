using System;
using System.Linq;

namespace NullableReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "José";
            int contagem = nome.Length;
            string textoVazio = string.Empty;
            contagem = textoVazio.Length;
            string? textoNulo = null;
            if (!string.IsNullOrEmpty(textoNulo))
                contagem = textoNulo.Length;
            string? outroTextoNulo = RetornaTextoNulo();
            if (!string.IsNullOrEmpty(outroTextoNulo))
                contagem = outroTextoNulo.Length;
        }

        public static string? RetornaTextoNulo()
        {
            string? textoVazio = null;
            return textoVazio;
        }
    }
}