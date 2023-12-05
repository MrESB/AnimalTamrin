using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public class Cow : Animal, IComparable<Cow>, IEnumerable<Cow>
    {
        public CowParameters CowParameters = new CowParameters();
        public List<CowParameters> cowParametersList = new List<CowParameters>();
        List<Cow> CowList = new List<Cow>();
        public static readonly int number;
        public int GetNumber() => number;
        public override int CostPerDay()
        {
            int costPerDay = (CowParameters.NumberOfMeal.Current * 300) + 700; // Number of meal * a meal price + herd managment cost
            return costPerDay;
        }
        public override int ValuePerDay()
        {
            int valuePerDay = (CowParameters.MilkProduction.Current * 300);
            return valuePerDay;
        }
        public int CompareTo(Cow? other)
        {
            if (other != null)
            {
                int costCompared;
                if (this.CostPerDay() > other.CostPerDay())
                {
                    costCompared = this.CostPerDay() - other.CostPerDay();
                    Console.WriteLine($"The first Cow has {costCompared} more costs than the other.");
                }
                else if (other.CostPerDay() > this.CostPerDay())
                {
                    costCompared = other.CostPerDay() - this.CostPerDay();
                    Console.WriteLine($"The second cow has {costCompared} more costs than the first one.");
                }
                else
                {
                    costCompared = this.CostPerDay() - other.CostPerDay();
                    Console.WriteLine($"both cows have even Costs per day.");
                }
                return costCompared;
            }
            else
            {
                Console.WriteLine("One of your cows hasn't enough information.");
                return -1;
            }
        }

        public IEnumerator<Cow> GetEnumerator()
        {
            return CowList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
