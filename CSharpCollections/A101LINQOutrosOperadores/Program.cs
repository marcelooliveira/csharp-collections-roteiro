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

            Console.WriteLine("Pegar o primeiro trimestre");
            Imprimir(meses.Take(3));

            Console.WriteLine("Pegar os meses depois do primeiro trimestre");
            Imprimir(meses.Skip(3));

            Console.WriteLine("Pegar os meses do terceiro trimestre");
            Imprimir(meses.Skip(6).Take(3));

            Console.WriteLine("Pegar os meses até que o mês comece com a letra 's'");
            Imprimir(meses.TakeWhile(m => !m.StartsWith("s")));

            Console.WriteLine("Pular os meses até que o mês comece com a letra 's'");
            Imprimir(meses.SkipWhile(m => !m.StartsWith("s")));

            // operadores de conjuntos
            string[] seq1 = { "janeiro", "fevereiro", "março"};
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };
            Console.WriteLine();

            Console.WriteLine("concatenando duas sequências");
            Imprimir(seq1.Concat(seq2));

            Console.WriteLine("união de duas sequências");
            Imprimir(seq1.Union(seq2));

            Console.WriteLine("união de duas sequências com comparador IgnoreCase");
            Imprimir(seq1.Union(seq2, StringComparer.CurrentCultureIgnoreCase));
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
