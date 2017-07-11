using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A81OutrosSetsEIterators
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
            ISet<Aluno> alunos = csharpColecoes.Alunos;

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            var enumerador = alunos.GetEnumerator();
            //enumerador.MoveNext(); //mostrar este método, que retorna true se houve um próximo

            Aluno alunoAtual = enumerador.Current;
            if (alunoAtual != null)
            {
                while (enumerador.MoveNext())
                {
                    Console.WriteLine(alunoAtual);
                }
            }

            //enumerador.MoveNext();
            //Aluno depoisDoUltimo = enumerador.Current;
        }
    }
}
