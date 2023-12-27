using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_2
{
    internal class Cello : MusicalInstrument
    {
        public Cello(string name, char model, double cost)
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
            Console.WriteLine("The cello came to the limelight for the first time in northern Italy in 1550. It is a member of the violin family and was initially called bass violin. In Italy, it was called viola da braccio. Andrea Amati was the first person who got exposure for making the cello.");
        }
    }

}
