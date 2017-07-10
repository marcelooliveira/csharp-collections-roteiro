using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A41MaisRelacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("Dominando as coleções do C#", "Marcelo Oliveira");

            //Adicionando várias aulas
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            ////Imprimindo várias aulas
            //IList<Aula> aulasImutaveis = csharpColecoes.Aulas;
            //ImprimeAulas(aulasImutaveis);

            //Copiando uma ReadonOnlyCollection para uma Lista e ordenando
            List<Aula> aulas = new List<Aula>(csharpColecoes.Aulas);
            aulas.Sort();
            ImprimeAulas(aulas);

            Console.WriteLine(csharpColecoes.TempoTotal);

            Console.WriteLine(csharpColecoes);
        }

        private static void ImprimeAulas(IList<Aula> aulas)
        {
            Console.WriteLine();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
