﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A24MaisRelacionamento
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

            //IList<Aula> aulas = csharpColecoes.Aulas;
            //aulas.Sort();
            //Não podemos ordenar um IList!
            //csharpColecoes.Aulas.Sort();

            //Imprimindo várias aulas
            IList<Aula> aulasImutavel = csharpColecoes.Aulas;
            ImprimeAulas(aulasImutavel);

            //Copiando uma ReadonOnlyCollection para uma Lista e ordenando
            List<Aula> aulas = new List<Aula>(csharpColecoes.Aulas);
            aulas.Sort();
            ImprimeAulas(aulas);

            //int tempoTotal = 0;
            //foreach (var aula in aulas)
            //{
            //    tempoTotal += aula.Tempo;
            //}
            //Console.WriteLine(tempoTotal);

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
