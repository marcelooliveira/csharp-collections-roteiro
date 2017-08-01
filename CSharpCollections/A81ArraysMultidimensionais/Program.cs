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
            ///<image url="$(ProjectDir)\Slides\image1.png" scale=""/>

            //var resultados = new string[]
            //{
            //    "Alemanha", "Argentina", "Holanda",
            //    "Espanha", "Holanda", "Alemanha",
            //    "Itália", "França", "Alemanha"
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




            const int COPA_2014 = 0;
            const int COPA_2010 = 1;
            const int COPA_2006 = 2;

            const int CAMPEAO = 0;
            const int VICE = 1;
            const int TERCEIRO = 2;

            int[] copas = new int[] { 2014, 2010, 2006 };

            string[,] resultados = new string[3, 3];

            resultados[COPA_2014, CAMPEAO] = "Alemanha";
            resultados[COPA_2014, VICE] = "Argentina";
            resultados[COPA_2014, TERCEIRO] = "Holanda";

            resultados[COPA_2010, CAMPEAO] = "Espanha";
            resultados[COPA_2010, VICE] = "Holanda";
            resultados[COPA_2010, TERCEIRO] = "Alemanha";

            resultados[COPA_2006, CAMPEAO] = "Itália";
            resultados[COPA_2006, VICE] = "França";
            resultados[COPA_2006, TERCEIRO] = "Alemanha";

            //foreach (var selecao in resultados)
            //{
            //    Console.WriteLine(selecao);
            //}

            for (int copa = resultados.GetLowerBound(0); 
                copa <= resultados.GetUpperBound(0); 
                copa++)
            {
                Console.Write(copas[copa] + " ");
                for (int posicao = resultados.GetLowerBound(1); 
                    posicao <= resultados.GetUpperBound(1); posicao++)
                {
                    Console.Write(resultados[copa, posicao] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
