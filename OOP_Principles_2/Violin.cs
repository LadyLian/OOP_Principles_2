using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_2
{
    internal class Violin:MusicalInstrument
    {
        public Violin(string name, char model, double cost)
        {
            Name = name;
            Model = model;
            Cost = cost;
        }
        public static void Sound(string sound, string name)
        {
            Console.WriteLine($"The sound for {name} is {sound}");
        }
        public static void Show(string name)
        {
            Console.WriteLine($"The name is {name}");
        }
        public static void Desc(char model)
        {
            Console.WriteLine($"The model is {model}");
        }
        public static void History()
        {
            Console.WriteLine("The violin in its present form emerged in early 16th-century northern Italy. The earliest pictures of violins, albeit with three strings, are seen in northern Italy around 1530, at around the same time as the words \"violino\" and \"vyollon\" are seen in Italian and French documents.");
        }
    }
}
