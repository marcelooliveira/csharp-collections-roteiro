using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A82JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int COPA_2014 = 0;
            const int COPA_2010 = 1;
            const int COPA_2006 = 2;

            int[] copas = new int[] { 2014, 2010, 2006 };

            string[][] resultados = new string[3][];

            resultados[COPA_2014] = new string[] { "Alemanha", "Argentina", "Holanda" };
            resultados[COPA_2010] = new string[] { "Espanha", "Holanda", "Alemanha" };
            resultados[COPA_2006] = new string[] { "Itália", "França", "Alemanha" };

            //mostrar que aqui não são mostrados os detalhes
            //foreach (var selecao in resultados)
            //{
            //    Console.WriteLine(selecao);
            //}

            for (int i = 0; i < resultados.Length; i++)
            {
                var posicoes = resultados[i];
                Console.Write(copas[i] + " ");
                foreach (var selecao in posicoes)
                {
                    Console.Write(selecao + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
