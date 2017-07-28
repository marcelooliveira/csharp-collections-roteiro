using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A31Relacionamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("Dominando as coleções do C#", "Marcelo Oliveira");

            ////Ensinando a acessar propriedade Aulas de um objeto Curso
            //List<Aula> aulas = csharpColecoes.Aulas;
            //Console.WriteLine();
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //Ensinando que aulas e csharpColecoes.Aulas são o mesmo objeto
            //aulas.Add(new Aula("Trabalhando com Listas", 21));
            //ImprimeAulas(aulas);
            //ImprimeAulas(csharpColecoes.Aulas); //mostra o mesmo que o anterior, ou seja, é o mesmo objeto!
            //Console.WriteLine(aulas == csharpColecoes.Aulas); //São iguais mesmo? Vamos verificar!

            ////Ensinando a encapsular e mover método de adição de elemento na classe Curso
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            ImprimeAulas(csharpColecoes.Aulas);

            ////Ensinando que os dois métodos fazem a mesma coisa
            //csharpColecoes.Aulas.Add(new Aula("Trabalhando com Listas", 21));
            //csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            //ImprimeAulas(csharpColecoes.Aulas);


            ////Ensinando a não permitir adição de aula fora da classe Curso
            //csharpColecoes.Aulas.Add(new Aula("Trabalhando com Listas", 21));
            //A linha acima produz: Exceção Sem Tratamento: System.NotSupportedException: Coleção é somente leitura.
            //mas a linha abaixo funciona!
            csharpColecoes.Adiciona(new Aula("Trabalhando com ReadOnlyCollection", 7));
            ImprimeAulas(csharpColecoes.Aulas);
        }

        //private static void ImprimeAulas(List<Aula> aulas)
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
