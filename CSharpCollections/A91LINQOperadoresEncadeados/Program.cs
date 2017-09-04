using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A91LINQOperadoresEncadeados
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Chaves", "Kiko", "Chiquinha", "Madruga", "Florinda", "Girafales" };
            
            Console.WriteLine("CONSULTANDO DENTRO DE UM LAÇO FOREACH");
            foreach (var nome in nomes)
            {
                if (nome.Contains("o"))
                {
                    Console.WriteLine(nome);
                }
            }
            Console.WriteLine();

            Console.WriteLine("CONSULTANDO COM LINQ");
            var query = nomes.Where(n => n.Contains("o"));
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            query = query.OrderBy(n => n.Length);

            query = query.Select(n => n.ToUpper());

            Console.WriteLine("OPERADORES ENCADEADOS");
            query = nomes
                .Where(n => n.Contains("o"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());

            //foreach (var item in consulta)
            //{
            //    Console.WriteLine(item);
            //}

            Imprimir(query);
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
