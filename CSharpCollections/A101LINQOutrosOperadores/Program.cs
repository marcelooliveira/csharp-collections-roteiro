using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A101LINQOutrosOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };

            // operadores de elementos:

            Console.WriteLine(meses.First());
            Console.WriteLine(meses.Last());

            Console.WriteLine(meses.ElementAt(1));
            Console.WriteLine(meses.OrderBy(m => m).First());
            Console.WriteLine(meses.OrderBy(m => m).Skip(1).First());

            // operadores de agregação

            Console.WriteLine(meses.Count());
            Console.WriteLine(meses.Min());

            // quantificadores

            Console.WriteLine(meses.Contains("março"));
            Console.WriteLine(meses.Any());
            Console.WriteLine(meses.Any(m => m.StartsWith("m")));

            // operadores de conjuntos

            string[] seq1 = { "janeiro", "fevereiro", "março" };
            string[] seq2 = { "outubro", "novembro", "dezembro" };
            Imprimir(seq1.Concat(seq2));
            Imprimir(seq1.Union(seq2));
        }

        private static void Imprimir(IEnumerable<string> consulta)
        {
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
