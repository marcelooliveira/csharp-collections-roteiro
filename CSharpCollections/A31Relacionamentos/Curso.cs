using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A31Relacionamentos
{
    class Curso
    {
        private string nome;
        private string instrutor;
        //A aula começa com List, depois muda para IList e ReadOnlyCollection
        //private List<Aula> aulas = new List<Aula>();
        private IList<Aula> aulas = new List<Aula>();

        public string Nome
        {
            get { return nome; }
        }

        public string Instrutor
        {
            get { return instrutor; }
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

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
        }

        public void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }
    }
}
