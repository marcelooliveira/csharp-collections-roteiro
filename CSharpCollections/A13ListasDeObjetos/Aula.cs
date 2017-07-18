using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13ListasDeObjetos
{
    //class Aula
    //{
    //    private string titulo;
    //    private int tempo;

    //    public string Titulo
    //    {
    //        get { return titulo; }
    //        set { titulo = value; }
    //    }

    //    public int Tempo
    //    {
    //        get { return tempo; }
    //        set { tempo = value; }
    //    }

    //    public Aula(string titulo, int tempo)
    //    {
    //        this.titulo = titulo;
    //        this.tempo = tempo;
    //    }

    //    public override string ToString()
    //    {
    //        return $"[Aula: {this.titulo}, {this.tempo} minutos]";
    //    }
    //}

    class Aula : IComparable
    {
        private string titulo;
        private int tempo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int Tempo
        {
            get { return tempo; }
            set { tempo = value; }
        }

        public Aula(string titulo, int tempo)
        {
            this.titulo = titulo;
            this.tempo = tempo;
        }

        public override string ToString()
        {
            return $"[Aula: {this.titulo}, {this.tempo} minutos]";
        }

        public int CompareTo(object obj)
        {
            Aula that = obj as Aula;
            return this.titulo.CompareTo(that.titulo);
        }
    }

}
