using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A102Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var navegador = new Navegador();
            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("alura.com.br");
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            navegador.Proximo();
        }
    }

    internal class Navegador
    {
        private string atual = "vazia";

        private readonly Stack<string> historicoAnterior 
            = new Stack<string>();
        private readonly Stack<string> historicoProximo
            = new Stack<string>();

        public Navegador()
        {
            Console.WriteLine(atual);
        }

        internal void Anterior()
        {
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                Console.WriteLine(atual);
            }
        }

        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine(atual);
        }

        internal void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine(atual);
            }
        }
    }
}