using ConsoleApp9.option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public abstract class AbstractAnimal
    {
        public string Species;
        public string Biome;
        public int Area;
        public string Meal;
        public string Sort;
        public string Sound;
        public string Name;
        public double FoodAmount;
        public int age;
        public BiomType biom;
        public double area;
        public AbstractAnimal(string name, int Age)
        {
            Name = name;
            age = Age;
        }

        public void Eat()
        {
            Console.WriteLine("nyam nyam");
        }

        public void MakeSound()
        {
            Console.WriteLine("auuu!");
        }

        public void Play()
        {
            Console.WriteLine("I'm running");
        }
        
    }
    
}
