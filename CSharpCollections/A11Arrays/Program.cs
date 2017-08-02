using System;

namespace CSharpCollections
{
    /// <summary>
    /// Image Comments:
    /// https://github.com/TomSmartBishop/image-comments/raw/master/Output/ImageComments.vsix
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Conhecendo mais de listas";
            string aulaModelando = "Modelando a classe Aula";
            string aulaSets = "Trabalhando com Cursos e Sets";

            string[] aulas = new string[]
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            ///<image url="$(ProjectDir)\Slides\aulas.jpg" scale=""/>
            //não imprime os itens!
            Console.WriteLine(aulas); //System.String[]
            // (colocar breakpoint) na linha anterior, investigar o objeto aulas

            //imprime os itens
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            //refatorando, temos um novo método:
            ImprimeAulas(aulas);
            
            //contando elementos
            Console.WriteLine("Quantidade: " + aulas.Length + " aulas");

            string primeiraAula = aulas[0];
            Console.WriteLine($"A primeira aula é: {primeiraAula}");

            string ultimaAula = aulas[aulas.Length - 1];
            Console.WriteLine($"A última aula é: {ultimaAula}");

            aulaIntro = "Conhecendo mais de arrays"; //não altera o array!
            ImprimeAulas(aulas);

            aulas[0] = "Conhecendo mais de arrays"; //agora sim, altera o array!
            ImprimeAulas(aulas);

            //removendo o último elemento (redimensionando o array)
            Array.Resize(ref aulas, aulas.Length - 1);
            Console.WriteLine();
            Console.WriteLine("Quantidade: " + aulas.Length + " aulas");
            ImprimeAulas(aulas);
            //Adicionando uma nova posição no final do array
            Array.Resize(ref aulas, aulas.Length + 1);
            Console.WriteLine();
            Console.WriteLine("Quantidade: " + aulas.Length + " aulas");
            ImprimeAulas(aulas);
            //Preenchendo a posição final com um valor
            aulas[aulas.Length - 1] = "Conclusão";
            ImprimeAulas(aulas);

            Array.Sort(aulas);
            Console.WriteLine();
            Console.WriteLine("Depois de ordenado:");
            ImprimeAulas(aulas);

            var copia = new string[aulas.Length - 1];
            Array.Copy(aulas, 1, copia, 0, aulas.Length - 1);
            aulas = copia;
            ImprimeAulas(aulas);

        }

        private static void ImprimeAulas(string[] aulas)
        {
            Console.WriteLine();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
