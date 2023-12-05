using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public class HealthParameters<T>
    {
        public string Name { get; set; }
        public T Current { get; set; }
        public T Max { get; set; }
        public T Min { get; set; }

        public override string ToString()
        {
            return $"The current amount of {Name} is {Current} and" + $"the standard amount is between {Min} and {Max}.";
        }
    }
}
