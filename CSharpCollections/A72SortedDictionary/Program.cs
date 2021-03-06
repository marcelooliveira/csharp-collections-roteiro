﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A72SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new SortedDictionary<string, Aluno>
            {
                {"VT", new Aluno("Vanessa Tonini", 34672)},
                {"AL", new Aluno("Ana Losnak", 5617)},
                {"RN", new Aluno("Rafael Nercessian", 17645)}
            };
            alunos.Add("WM",
                new Aluno("Wanderson Macedo", 11287));

            Console.WriteLine(alunos["RN"]);

            foreach (var a in alunos)
                Console.WriteLine(a);

            ///<image url="$(ProjectDir)\Slides\image1.png" scale=""/>
            ///<image url="$(ProjectDir)\Slides\image2.png" scale=""/>
        }
    }
}
