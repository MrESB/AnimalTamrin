using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public abstract class Animal
    {
        DairyEnvironment DairyEnvironment = new DairyEnvironment();
        public List<DairyEnvironment> Environment = new List<DairyEnvironment>();
        public DateOnly BirthDate { get; init; }
        static readonly int maxLife = 20;
        static int GetMaxLife() => maxLife;
        public float weight;
        public string gender;
        public string name;
        public int age;
        public double StressFactor() => DairyEnvironment.TotalImpactOnLife();
        public int Life()
        {
            int life = (int)(age - (age * StressFactor()));
            if (life < age)
                life = age;
            else if (life > maxLife)
                life = maxLife;
            return life;
        }
        public int YearsBeforeDeath() => maxLife - Life(); //Time TO Die
        public double KillPriority() => Life() - age;
        public virtual int CostPerDay()
        {
            int costPerDay = 0;
            return costPerDay;
        }
        public virtual int ValuePerDay()
        {
            int valuePerDay = 0;
            return valuePerDay;
        }



    }
}
