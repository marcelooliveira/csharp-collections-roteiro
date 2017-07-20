using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A81OutrosSetsEIterators
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("Dominando as coleções do C#", "Marcelo Oliveira");

            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            foreach (var aula in csharpColecoes.Aulas)
            {
                Console.WriteLine(aula);
            }

            var enumerador = csharpColecoes.Aulas.GetEnumerator();
            Console.WriteLine("Aula atual: " + enumerador.Current);

            while (enumerador.MoveNext())
            {
                Console.WriteLine(enumerador.Current);
            }

            Console.WriteLine("Depois da última: " + enumerador.Current);

            enumerador.Reset();
            while (enumerador.MoveNext())
            {
                Console.WriteLine(enumerador.Current);
            }

            enumerador.Reset();
            while (enumerador.MoveNext())
            {
                csharpColecoes.Adiciona(new Aula("Conclusão", 3)); //habilitando essa linha obtemos InvalidOperationException
                Console.WriteLine(enumerador.Current);
            }
        }
    }
}
