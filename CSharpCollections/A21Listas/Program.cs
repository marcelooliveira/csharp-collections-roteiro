using System;
using System.Linq;
using System.Collections.Generic;

namespace A12Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            Console.WriteLine("A primeira aula é " + aulas[0]);
            Console.WriteLine("A primeira aula é " + aulas.First());

            Console.WriteLine("A última aula é " + aulas[aulas.Count - 1]);
            Console.WriteLine("A última aula é " + aulas.Last());

            aulas[0] = "Trabalhando com Listas";
            Imprimir(aulas);

            Console.WriteLine("A primeira aula 'Trabalhando' é: "
                + aulas.First(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A última aula 'Trabalhando' é: "
                + aulas.Last(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A primeira aula 'Conclusão' é: "
                + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

            aulas.Reverse();
            Imprimir(aulas);

            aulas.Reverse();
            Imprimir(aulas);

            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            aulas.Add("Conclusão");
            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);

            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);

            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);

        }

        private static void Imprimir(List<string> aulas)
        {
            Console.Clear();

            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}

            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
            Console.WriteLine();
        }
    }
}
