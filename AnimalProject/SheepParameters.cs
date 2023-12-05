using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public class SheepParameters
    {
        public HealthParameters<int> standingTime = new HealthParameters<int>()
        {
            Name = "Standing time",
            Current = 9,
            Min = 6,
            Max = 12,
        };
        public HealthParameters<int> herdManagmentTime = new HealthParameters<int>()
        {
            Name = "Herd managment activities time",
            Current = 3,
            Min = 2,
            Max = 3,
        };
        public HealthParameters<int> relaxingTime = new HealthParameters<int>()
        {
            Name = "Lying or resting ime",
            Current = 2,
            Min = 12,
            Max = 18,
        };
        public HealthParameters<int> NumberOfMeal = new HealthParameters<int>()
        {
            Name = "Meals per day",
            Current = 3,
            Min = 2,
            Max = 3,
        };
        public HealthParameters<int> MilkProduction = new HealthParameters<int>()
        {
            Name = "Milk production amount",
            Current = 3,
            Min = 2,
            Max = 4,
        };
        public DateOnly date = new DateOnly();
        public override string ToString()
        {
            List<HealthParameters<int>> healthParameters = new List<HealthParameters<int>>()
                {standingTime, herdManagmentTime, relaxingTime, NumberOfMeal, MilkProduction};
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in healthParameters)
            {
                stringBuilder.AppendLine($"{item.ToString()}");
            }
            return stringBuilder.ToString();

        }
    }
}
