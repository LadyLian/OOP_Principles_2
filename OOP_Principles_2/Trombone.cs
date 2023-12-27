using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_2
{
    internal class Trombone:MusicalInstrument
    {
        public Trombone(string name, char model, double cost)
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
            Console.WriteLine("The trombone is said to have been created in the middle of the 15th century. Until the 18th century the trombone was called a \"saqueboute\" (in French) or a \"sackbut\" (in English).");
        }
    }
}

