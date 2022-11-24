using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Zebra : AbstractAnimal

    {
        public Zebra(string Name, int Age, double FoodAmount) : base(Name, Age, FoodAmount)
        {
            this.Age = Age;
            this.FoodAmount = FoodAmount;
            this.Name = Name;
        }
        
       
      
        
    }
}
