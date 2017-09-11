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
            var meses =
                Enumerable
                .Range(1, 12)
                .Select(m => new Mes(
                    new DateTime(2017, m, 1).ToString("MMMM"),
                    DateTime.DaysInMonth(2017, m)
                ));

            Console.WriteLine("Pegar o primeiro trimestre");
            Imprimir(meses.Take(3));

            Console.WriteLine("Pegar os meses depois do primeiro trimestre");
            Imprimir(meses.Skip(3));

            Console.WriteLine("Pegar os meses do terceiro trimestre");
            Imprimir(meses.Skip(6).Take(3));

            Console.WriteLine("Pegar os meses até que o mês comece com a letra 's'");
            Imprimir(meses.TakeWhile(m => !m.Nome.StartsWith("s")));

            Console.WriteLine("Pular os meses até que o mês comece com a letra 's'");
            Imprimir(meses.SkipWhile(m => !m.Nome.StartsWith("s")));

            // operadores de conjuntos
            string[] seq1 = { "janeiro", "fevereiro", "março"};
            string[] seq2 = { "fevereiro", "MARÇO", "abril" };
            Console.WriteLine();

            Console.WriteLine("concatenando duas sequências");
            foreach (var item in seq1.Concat(seq2))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("união de duas sequências");
            foreach (var item in seq1.Union(seq2))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("união de duas sequências com comparador IgnoreCase");
            foreach (var item in seq1.Union(seq2, StringComparer.CurrentCultureIgnoreCase))
            {
                Console.WriteLine(item);
            }
        }

        private static void Imprimir(IEnumerable<Mes> consulta)
        {
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }

    class Mes
    {
        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public string Nome { get; private set; }
        public int Dias { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Nome, Dias);
        }
    }
}
