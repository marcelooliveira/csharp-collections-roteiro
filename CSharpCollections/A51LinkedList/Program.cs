using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10LinkedListStackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            ///<image url="$(ProjectDir)\Slides\image1.png" scale=""/>
            List<string> frutas = new List<string>()
            {
                "abacate", "banana", "caqui", "damasco", "figo"
            };

            foreach (var f in frutas)
            {
                Console.WriteLine(f);
            }

            frutas.Insert(2, "caju");

            ///<image url="$(ProjectDir)\Slides\image2.png" scale=""/>
            foreach (var f in frutas)
            {
                Console.WriteLine(f);
            }

            ///<image url="$(ProjectDir)\Slides\linked.png" scale=""/>

            ///<image url="$(ProjectDir)\Slides\linked2.png" scale=""/>
            LinkedList<string> dias = new LinkedList<string>();

            var d4 = dias.AddFirst("quarta");
            ///<image url="$(ProjectDir)\Slides\image3.png" scale=""/>
            var d2 = dias.AddBefore(d4, "segunda");
            ///<image url="$(ProjectDir)\Slides\image4.png" scale=""/>
            var d3 = dias.AddAfter(d2, "terça");
            ///<image url="$(ProjectDir)\Slides\image5.png" scale=""/>
            var d6 = dias.AddAfter(d4, "sexta");
            ///<image url="$(ProjectDir)\Slides\image6.png" scale=""/>
            var d7 = dias.AddAfter(d6, "sábado");
            ///<image url="$(ProjectDir)\Slides\image7.png" scale=""/>
            var d5 = dias.AddBefore(d6, "quinta");
            ///<image url="$(ProjectDir)\Slides\image8.png" scale=""/>
            var d1 = dias.AddBefore(d2, "domingo");
            ///<image url="$(ProjectDir)\Slides\image9.png" scale=""/>

            foreach (var d in dias)
            {
                Console.WriteLine(d);
            }

            dias.Remove(d4);

            foreach (var d in dias)
            {
                Console.WriteLine(d);
            }
        }
    }
}
