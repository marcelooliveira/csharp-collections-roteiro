using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A91NocoesLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Chaves", "Kiko", "Chiquinha", "Madruga", "Florinda", "Girafales" };

            IEnumerable<string> consulta = nomes
                .Where(n => n.Contains("o"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());

            //foreach (var item in consulta)
            //{
            //    Console.WriteLine(item);
            //}

            Imprimir(consulta);

            IEnumerable<string> filtrados = nomes.Where(n => n.Contains("a"));
            IEnumerable<string> ordenados = filtrados.OrderBy(n => n.Length);
            IEnumerable<string> maiusculas = ordenados.Select(n => n.ToUpper());

            Imprimir(filtrados);
            Imprimir(ordenados);
            Imprimir(maiusculas);
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
