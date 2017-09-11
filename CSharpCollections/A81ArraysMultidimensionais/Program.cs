using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A81ArraysMultidimensionais
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<image url="$(ProjectDir)\Slides\img1.png" scale=""/>

            //var resultados = new string[]
            //{
            //    "Alemanha", "Espanha", "Itália",
            //    "Argentina", "Holanda", "França",
            //    "Holanda", "Alemanha", "Alemanha"
            //};

            //foreach (var item in resultados)
            //{
            //    Console.WriteLine(item);
            //}




            //string[,] resultados = new string[3, 3];
            //resultados[0, 0] = "Alemanha";
            //resultados[0, 1] = "Argentina";
            //resultados[0, 2] = "Holanda";

            //resultados[1, 0] = "Espanha";
            //resultados[1, 1] = "Holanda";
            //resultados[1, 2] = "Alemanha";

            //resultados[2, 0] = "Itália";
            //resultados[2, 1] = "França";
            //resultados[2, 2] = "Alemanha";

            //foreach (var item in resultados)
            //{
            //    Console.WriteLine(item);
            //}




            string[,] resultados = new string[3, 3];

            resultados[0, 0] = "Alemanha";
            resultados[0, 1] = "Argentina";
            resultados[0, 2] = "Holanda";

            resultados[1, 0] = "Espanha";
            resultados[1, 1] = "Holanda";
            resultados[1, 2] = "Alemanha";

            resultados[2, 0] = "Itália";
            resultados[2, 1] = "França";
            resultados[2, 2] = "Alemanha";

            //foreach (var selecao in resultados)
            //{
            //    Console.WriteLine(selecao);
            //}

            for (int copa = 0; copa <= resultados.GetUpperBound(0); copa++)
            {
                int ano = 2014 - 4 * copa;
                Console.Write(ano.ToString().PadRight(12));
            }
            Console.WriteLine();
            for (int posicao = 0; posicao <= resultados.GetUpperBound(1); posicao++)
            {
                for (int copa = 0; copa <= resultados.GetUpperBound(0); copa++)
                {
                    Console.Write(resultados[copa, posicao].PadRight(12));
                }
                Console.WriteLine();
            }
        }
    }
}
