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
            //string[] familias = new string[] { 2014, 2010, 2006 };

            string[][] familias = new string[3][];

            familias[0] = new string[] 
            { "Fred", "Wilma", "Pedrita" };
            familias[1] = new string[] 
            { "Homer", "Marge", "Bart", "Lisa", "Maggie" };
            familias[2] = new string[] 
            { "Florinda", "Kiko" };

            //mostrar que aqui não são mostrados os detalhes

            for (int i = 0; i < familias.Length; i++)
            {
                var familia = familias[i];
                foreach (var pessoa in familia)
                {
                    Console.Write(pessoa + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
