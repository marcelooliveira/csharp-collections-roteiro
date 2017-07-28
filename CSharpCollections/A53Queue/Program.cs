using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A103Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            //string veiculo = "van";
            //Console.WriteLine($"Entrou na fila: {veiculo}");
            //pedagio.Enqueue(veiculo);
            //foreach (var v in pedagio)
            //{
            //    Console.WriteLine(v);
            //}

            //string veiculo = "van";
            //Enfileirar(veiculo);

            Enfileirar("van");
            ///<image url="$(ProjectDir)\Slides\queue1.png" scale=""/>

            Enfileirar("kombi");
            ///<image url="$(ProjectDir)\Slides\queue2.png" scale=""/>
            Enfileirar("guincho");
            ///<image url="$(ProjectDir)\Slides\queue3.png" scale=""/>
            Enfileirar("pickup");
            ///<image url="$(ProjectDir)\Slides\queue4.png" scale=""/>

            Desenfileirar();
            ///<image url="$(ProjectDir)\Slides\queue5.png" scale=""/>
            Desenfileirar();
            ///<image url="$(ProjectDir)\Slides\queue6.png" scale=""/>
            Desenfileirar();
            ///<image url="$(ProjectDir)\Slides\queue7.png" scale=""/>
            Desenfileirar();
            Desenfileirar();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("Guincho está esperando no pedágio.");
                }
                var veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimeFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            //Console.WriteLine($"Entrou na fila: {veiculo}");
            //pedagio.Enqueue(veiculo);
            //foreach (var v in pedagio)
            //{
            //    Console.WriteLine(v);
            //}

            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimeFila();
        }

        private static void ImprimeFila()
        {
            Console.WriteLine("FILA:");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
        }
    }
}
