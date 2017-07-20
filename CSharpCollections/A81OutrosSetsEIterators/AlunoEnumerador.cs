using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A81OutrosSetsEIterators
{
    public class AlunoEnumerador : IEnumerator
    {
        public readonly Aluno[] _alunos;

        int posicao = -1;

        public AlunoEnumerador(Aluno[] alunos)
        {
            _alunos = alunos;
        }

        public bool MoveNext()
        {
            posicao++;
            return (posicao < _alunos.Length);
        }

        public void Reset()
        {
            posicao = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Aluno Current
        {
            get
            {
                try
                {
                    return _alunos[posicao];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
