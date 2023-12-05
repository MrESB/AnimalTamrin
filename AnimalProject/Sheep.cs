using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public class Sheep : Animal, IComparable<Sheep>, IEnumerable<Sheep>
    {
        public SheepParameters sheepParameters = new SheepParameters();
        public List<Sheep> sheepList = new List<Sheep>();
        public List<SheepParameters> sheepParametersList = new List<SheepParameters>();
        
        public static int number;
        public int GetNumber() => number;
        public override int CostPerDay()
        {
            int costPerDay = (sheepParameters.NumberOfMeal.Current * 150) + 500; // Number of meal * a meal price + herd managment cost
            return costPerDay;
        }
        public override int ValuePerDay()
        {
            int valuePerDay = (sheepParameters.MilkProduction.Current * 100);
            return valuePerDay;
        }
        public int CompareTo(Sheep? other)
        {
            if (other != null)
            {
                int costCompared;
                if (this.CostPerDay() > other.CostPerDay())
                {
                    costCompared = this.CostPerDay() - other.CostPerDay();
                    Console.WriteLine($"The first sheep has {costCompared} more costs than the other one.");
                }
                else if (other.CostPerDay() > this.CostPerDay())
                {
                    costCompared = other.CostPerDay() - this.CostPerDay();
                    Console.WriteLine($"The second sheep has {costCompared} more costs than the first one.");
                }
                else
                {
                    costCompared = this.CostPerDay() - other.CostPerDay();
                    Console.WriteLine($"both sheeps have even Costs per day.");
                }
                return costCompared;
            }
            else
            {
                Console.WriteLine("One of your sheeps hasn't enough information.");
                return -1;
            }
        }

        public IEnumerator<Sheep> GetEnumerator()
        {
            return sheepList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
