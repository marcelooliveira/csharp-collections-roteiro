using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula aulaIntro = new Aula("Introdução às Coleções", 21);
            Aula aulaModelando = new Aula("Modelando a Classe Aula", 15);
            Aula aulaSets = new Aula("Trabalhando com Conjuntos", 13);

            //List<Aula> aulas = new List<Aula>();
            //aulas.Add(aulaIntro);
            //aulas.Add(aulaModelando);
            //aulas.Add(aulaSets);

            //A inicialização acima vai ser simplificada abaixo

            List<Aula> aulas = new List<Aula>
             {
                 aulaIntro,
                 aulaModelando,
                 aulaSets
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
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula); //não exibe detalhes da aula, pois precisamos implementar ToString()
            }
        }
    }
}
