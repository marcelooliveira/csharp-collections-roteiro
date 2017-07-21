using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A101Mapas
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Curso csharpColecoes = new Curso("Dominando as coleções do C#", "Marcelo Oliveira");

        //    csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
        //    csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
        //    csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

        //    Aluno a1 = new Aluno("Vanessa Tonini", 34672);
        //    Aluno a2 = new Aluno("Ana Losnak", 5617);
        //    Aluno a3 = new Aluno("Rafael Nercessian", 17645);

        //    csharpColecoes.Matricula(a1);
        //    csharpColecoes.Matricula(a2);
        //    csharpColecoes.Matricula(a3);

        //    foreach (var aula in csharpColecoes.Aulas)
        //    {
        //        Console.WriteLine(aula);
        //    }

        //    Console.WriteLine("Quem é o aluno com matrícula 5617?");
        //    Aluno aluno = csharpColecoes.BuscaMatriculado(5617);
        //    Console.WriteLine("aluno: " + aluno);

        //    Console.WriteLine("Quem é o aluno com matrícula 5618?");
        //    aluno = csharpColecoes.BuscaMatriculado(5618);
        //    Console.WriteLine("aluno: " + aluno);
        //}

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

            //Console.WriteLine("Quem é o aluno com matrícula 5617?");
            //Aluno aluno = csharpColecoes.BuscaMatriculado(5617);
            //Console.WriteLine("aluno: " + aluno);

            Console.WriteLine("Quem é o aluno com matrícula 5618?");
            Aluno aluno = csharpColecoes.BuscaMatriculado(5618);
            Console.WriteLine("aluno: " + aluno);

            //A linha abaixo gera um erro,
            //pois a chave aluno.NumeroMatricula não é única
            //no dicionário:
            Aluno a4 = new Aluno("Fabio Gushiken", 5617);
            //csharpColecoes.Matricula(a4);
            csharpColecoes.SubstituiMatricula(a4);

            Console.WriteLine("Quem é o aluno com matrícula 5617?");
            aluno = csharpColecoes.BuscaMatriculado(5617);
            Console.WriteLine("aluno: " + aluno);
        }
    }
}
