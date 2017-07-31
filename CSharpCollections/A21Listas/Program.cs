﻿using System;
using System.Collections.Generic;

namespace A12Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            string aula1 = "Conhecendo mais de listas";
            string aula2 = "Modelando a classe Aula";
            string aula3 = "Trabalhando com Cursos e Sets";

            //List<string> aulas = new List<string>();
            //aulas.Add(aula1);
            //aulas.Add(aula2);
            //aulas.Add(aula3);

            //A inicialização acima vai ser simplificada abaixo

            List<string> aulas = new List<string>
            {
                aula1,
                aula2,
                aula3
            };

            //não imprime os itens!
            Console.WriteLine(aulas);
            // (colocar breakpoint) na linha anterior, investigar o objeto aulas

            //imprime os itens
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            //removendo aula
            aulas.RemoveAt(0);

            ImprimeAulas(aulas);

            //imprimindo aulas com interpolação de string
            Console.WriteLine();
            foreach (var aula in aulas)
            {
                Console.WriteLine($"aula: {aula}");
            }

            string primeiraAula = aulas[0];
            Console.WriteLine($"A primeira aula é: {primeiraAula}");

            Console.WriteLine();
            for (int i = 0; i < aulas.Count; i++)
            {
                Console.WriteLine($"aula {i}: {aulas[i]}");
            }

            Console.WriteLine();
            Console.WriteLine($"tamanho: {aulas.Count}");

            Console.WriteLine();

            aulas.ForEach(PercorrerAula);

            aulas.ForEach(aula =>
            {
                Console.WriteLine("percorrendo:");
                Console.WriteLine($"Aula: {aula}");
            });

            aulas.Add("Aumentando nosso conhecimento");
            ImprimeAulas(aulas);

            aulas.Sort();
            Console.WriteLine();
            Console.WriteLine("Depois de ordenado:");
            ImprimeAulas(aulas);
        }

        private static void PercorrerAula(string aula)
        {
            Console.WriteLine("percorrendo:");
            Console.WriteLine($"Aula: {aula}");
        }

        private static void ImprimeAulas(List<string> aulas)
        {
            Console.WriteLine();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}