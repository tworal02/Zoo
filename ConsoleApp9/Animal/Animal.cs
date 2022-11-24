using ConsoleApp9;
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
       

     
        public string Meal { get; set; }
        public string Sort { get; set; }
        public  string Sound { get; set; }
        public  string Name { get; set; }
        public  double FoodAmount { get; set; }
        public int Age { get; set; }
        public  double Area { get; set; }
        public AbstractAnimal(string Name, int Age,double FoodAmount)
        { 
            this.Name = Name;
            this.Age = Age;
            this.FoodAmount = FoodAmount;   
        }

        public abstract void Eat();


        public abstract void MakeSound();


        public abstract void Play();
       
        
    }
}
