using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A111Covariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            // cast de string para objeto funciona sem problemas...
            string titulo = "The Simpsons";
            object obj = titulo;

            // ... mas não funciona fazer cast de List<string> para List<object> !
            var familia = new List<string> { "Homer", "Marge", "Bart", "Lisa", "Maggie" };
            //  List<object> listaObj = familia; // essa linha dá erro!

            // mas cast para IEnumerable<object> funciona...
            IEnumerable<object> objEnum = familia;

            //Devido à covariância de arrays, podemos fazer um cast de 
            //array de strings para array de objects!
            var familiaArray = new string[] { "Dona Florinda", "Kiko" };
            object[] objArray = familiaArray;
            //MAS ATENÇÃO! objArray que recebeu cast de string[]
            //  não pode receber um int!
            //objArray[0] = 123;

            //PARA SABER MAIS:Array covariance
            //https://msdn.microsoft.com/en-us/library/aa664572(v=vs.71).aspx
        }
    }
}
