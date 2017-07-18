using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula a1 = new Aula("Revisitando listas", 21);
            Aula a2 = new Aula("Listas de objetos", 15);
            Aula a3 = new Aula("Relacionamento de listas e objetos", 13);

            //List<Aula> aulas = new List<Aula>();
            //aulas.Add(a1);
            //aulas.Add(a2);
            //aulas.Add(a3);

            //A inicialização acima vai ser simplificada abaixo

            List<Aula> aulas = new List<Aula>
             {
                 a1,
                 a2,
                 a3
             };

            ////a próxima linha gera um erro de compilação!
            //aulas.Add("Equals e HashCode");

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula); //não exibe detalhes da aula, pois precisamos implementar ToString()
            }

            //Após implementarmos ToString() em Aula, a linha acima exibe corretamente a aula

            aulas.Sort();
            ////Exceção Sem Tratamento: System.InvalidOperationException: 
            //Falha ao comparar dois elementos na matriz. --->System.ArgumentException: 
            //Pelo menos um objeto deve implementar IComparable.

            ImprimeAulas(aulas);

            //vamos ordenar de outro jeito agora
            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));

            ImprimeAulas(aulas);

        }

        private static void ImprimeAulas(List<Aula> aulas)
        {
            Console.WriteLine();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula); //não exibe detalhes da aula, pois precisamos implementar ToString()
            }
        }
    }
}
