using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A72SortedList
{
    public class Aluno
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
        }

        private int numeroMatricula;
        public int NumeroMatricula
        {
            get { return numeroMatricula; }
        }

        public Aluno(String nome, int numeroMatricula)
        {
            //as linhas abaixo são adicionadas depois
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("Nome deve ser informado");
            }
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public override string ToString()
        {
            return "[Aluno: " + this.nome + ", matricula: " + this.numeroMatricula + "]";
        }

        public override bool Equals(object obj)
        {
            Aluno that = obj as Aluno;
            return that.nome.Equals(that.nome);
        }

        public override int GetHashCode()
        {
            //return this.nome[0];
            return this.nome.GetHashCode();
        }
    }
}
