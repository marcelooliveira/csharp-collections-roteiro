﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A71SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new SortedList<string, Aluno>
            {
                {"VT", new Aluno("Vanessa Tonini", 34672)},
                {"AL", new Aluno("Ana Losnak", 5617)},
                {"RN", new Aluno("Rafael Nercessian", 17645)}
            };
            alunos.Add("WM",
                new Aluno("Wanderson Macedo", 11287));

            alunos["WM"] = new Aluno("Wanderson Macedo", 11287);

            Console.WriteLine(alunos["RN"]);

            //Console.WriteLine(alunos["XX"]); //dá erro!
            Aluno aluno = null;
            alunos.TryGetValue("XX", out aluno);
            Console.WriteLine(aluno);

            foreach (var a in alunos)
                Console.WriteLine(a);

            var index = alunos.IndexOfKey("VT");
            Console.WriteLine(index);

            ///<image url="$(ProjectDir)\Slides\image1.png" scale=""/>
        }
    }
}
