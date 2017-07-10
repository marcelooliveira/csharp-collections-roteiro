using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A51Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            //ISet<String> alunos = new HashSet<String>();
            //alunos.Add("Vanessa Tonini");
            //alunos.Add("Ana Losnak");
            //alunos.Add("Rafael Nercessian");
            //Console.WriteLine(string.Join(", ", alunos));


            //ISet<String> alunos = new HashSet<String>();
            //alunos.Add("Vanessa Tonini");
            //alunos.Add("Ana Losnak");
            //alunos.Add("Rafael Nercessian");
            //alunos.Add("Priscila Stuani");
            //alunos.Add("Rafael Rollo");
            //alunos.Add("Fabio Gushiken");
            //Console.WriteLine(string.Join(", ", alunos));


            //ISet<String> alunos = new HashSet<String>();
            ICollection<String> alunos = new HashSet<String>();
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Gushiken");
            alunos.Add("Fabio Gushiken");//não adiciona um novo nem gera erro!
            Console.WriteLine(string.Join(", ", alunos));
            Console.WriteLine(alunos.Count);

            bool vanessaEstaMatriculada = alunos.Contains("Vanessa Tonini");
            Console.WriteLine(vanessaEstaMatriculada);

            alunos.Remove("Rafael Rollo");
            Console.WriteLine(string.Join(", ", alunos));

            List<string> lista = new List<string>(alunos);

            lista.Sort();
            Console.WriteLine(string.Join(", ", lista));

        }
    }
}
