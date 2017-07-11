using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualCollectionUsar
{
    class Curso
    {
        private string nome;
        private string instrutor;
        //A aula começa com List, depois muda para IList e ReadOnlyCollection
        //private List<Aula> aulas = new List<Aula>();
        private IList<Aula> aulas = new List<Aula>();
        ISet<Aluno> alunos = new HashSet<Aluno>();

        public string Nome
        {
            get { return nome; }
        }

        public string Instrutor
        {
            get { return instrutor; }
        }

        internal void Matricula(Aluno aluno)
        {
            this.alunos.Add(aluno);
        }

        //A aula começa com List, depois muda para IList e ReadOnlyCollection
        //public List<Aula> Aulas
        //{
        //    get { return aulas; }
        //}

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        internal bool EstaMatriculado(Aluno aluno)
        {
            return this.alunos.Contains(aluno);
        }

        //public IList<Aluno> Alunos
        public ISet<Aluno> Alunos
        {
            get
            {
                return new HashSet<Aluno>(alunos.ToList());
            }
        }
        
        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
        }

        public void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        //public int TempoTotal
        //{
        //    get
        //    {
        //        int tempoTotal = 0;
        //        foreach (var aula in aulas)
        //        {
        //            tempoTotal += aula.Tempo;
        //        }

        //        return tempoTotal;
        //    }
        //}

        public int TempoTotal
        {
            get
            {
                return aulas.Sum(a => a.Tempo);
            }
        }

        public override string ToString()
        {
            IEnumerable<string> aulasString = aulas.Select(a => a.ToString());
            return $"[Curso: {nome}, tempo total: {TempoTotal}, aulas: {string.Join(",", aulasString)}]";
        }
    }
}
