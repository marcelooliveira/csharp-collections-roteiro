using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A92LINQOrdenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };

            Imprimir(meses.Take(3));
            Imprimir(meses.Skip(3));
            Imprimir(meses.Reverse());
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
