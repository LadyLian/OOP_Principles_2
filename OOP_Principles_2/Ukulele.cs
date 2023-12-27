using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_2
{
    internal class Ukulele:MusicalInstrument
    {
        public Ukulele(string name, char model, double cost)
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
            Console.WriteLine("Developed in the 1880s, the ukulele is based on several small, guitar-like instruments of Portuguese origin, the machete, cavaquinho, timple, and rajão, introduced to the Hawaiian Islands by Portuguese immigrants from Madeira, the Azores and Cape Verde.");
        }
    }
}
