using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualCollectionUsar
{
    class Program
    {   
        static void Main(string[] args)
        {
            Collection<Aluno> alunos = new Collection<Aluno>();
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);
            alunos.Add(a1);
            alunos.Add(a2);
            alunos.Add(a3);

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
