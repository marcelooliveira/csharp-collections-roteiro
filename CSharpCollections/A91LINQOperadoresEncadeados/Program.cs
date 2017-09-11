using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A91LINQOperadoresEncadeados
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEMA: obter os nomes dos meses do ano
            //que tem 31 dias, em maiúsculo e em ordem alfabética

            var meses = 
                Enumerable
                .Range(1, 12)
                .Select(m => new Mes(                
                    new DateTime(2017, m, 1).ToString("MMMM"),
                    DateTime.DaysInMonth(2017, m)
                ));


            Console.WriteLine("CONSULTANDO DENTRO DE UM LAÇO FOREACH");
            Console.WriteLine("Meses com 31 dias");
            foreach (var mes in meses)
            {
                if (mes.Dias == 31)
                {
                    Console.WriteLine(mes);
                }
            }
            Console.WriteLine();

            Console.WriteLine("CONSULTANDO COM LINQ");
            var query = meses.Where(m => m.Dias == 31);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var query2 = query.OrderBy(m => m.Nome);

            var query3 = query2.Select(m => m.Nome.ToUpper());

            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("OPERADORES ENCADEADOS");
            var query4 = meses
                .Where(m => m.Dias == 31)
                .OrderBy(m => m.Nome)
                .Select(m => m.Nome.ToUpper());

            foreach (var item in query4)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Mes
    {
        public Mes(string nome, int dias)
        {
            Nome = nome;
            Dias = dias;
        }

        public string Nome { get; private set; }
        public int Dias { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Nome, Dias);
        }
    }
}
