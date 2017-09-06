using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A73SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<String> alunos = new SortedSet<String>(new ComparadorMinusculo())
            {
                "Vanessa Tonini",
                "Ana Losnak",
                "Rafael Nercessian",
                "Priscila Stuani"
            };

            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");
            alunos.Add("FABIO GUSHIKEN");
            foreach (var a in alunos)
                Console.WriteLine(a);

            var faixaAlunos = alunos.GetViewBetween("F", "R");
            foreach (var item in faixaAlunos)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
