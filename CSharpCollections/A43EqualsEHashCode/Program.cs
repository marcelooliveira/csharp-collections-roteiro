using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A71EqualsEHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("Dominando as coleções do C#", "Marcelo Oliveira");

            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            Console.WriteLine("Todos os alunos matriculados: ");
            csharpColecoes.Alunos.ToList().ForEach(aluno => {
                Console.WriteLine(aluno);
            });

            Console.WriteLine("O aluno " + a3.Nome + " está matriculado?");
            Console.WriteLine(csharpColecoes.EstaMatriculado(a3));

            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine("E essa Tonini, está matriculada?");
            Console.WriteLine(csharpColecoes.EstaMatriculado(tonini));

            Console.WriteLine("O a1 é == à Tonini?");
            Console.WriteLine(a1 == tonini);

            //Console.WriteLine("O a1 é equals à Tonini?");
            //antes do Aluno.Equals(): false
            //Console.WriteLine(a1.Equals(tonini));
            //depois do Aluno.Equals(): true
            Console.WriteLine(a1.Equals(tonini));

            Console.WriteLine(a1.GetHashCode()); /*643022057*/
            Console.WriteLine(a1.GetHashCode() == tonini.GetHashCode()); /*643022057*/
        }
    }
}
