using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalProject
{
    public class DairyEnvironment
    {
        public HealthParameters<double> totalDissolvedSolids = new HealthParameters<double>()
        {
            Name = "Total Dissolved Solids",
            Current = 1400,
            Max = 2999.00,
            Min = 1000.00,
        };
        public HealthParameters<double> heat = new HealthParameters<double>()
        {
            Name = "Heat (Fahrenheit)",
            Current = 82.00,
            Max = 102.00,
            Min = 86.00,
        };
        public HealthParameters<double> Overcrowding = new HealthParameters<double>()
        {
            Name = "Over Crowding",
            Current = 100.00,
            Max = 120.00,
            Min = 0
        };
        public HealthParameters<double> noiseLevel = new HealthParameters<double>()
        {
            Name = "Noise Level",
            Current = 89.00,
            Max = 85,
            Min= 0
        };
        public HealthParameters<double> airQualityIndex = new HealthParameters<double>()
        {
            Name = "Air Quality Index",
            Current = 100,
            Max = 140,
            Min = 0
        };
        public HealthParameters<double> oxygenAmount = new HealthParameters<double>()
        {
            Name = "Oxygen amount",
            Current = 98.6,
            Max = 98.4,
            Min = 97.00
        };
        public DateOnly date = new DateOnly();
        
        private double HealthParameterImpact(HealthParameters<double> healthParameter)
        {
            double impact;
            if (healthParameter.Current > healthParameter.Max)
                impact = (healthParameter.Max - healthParameter.Current) / 100;
            else if (healthParameter.Current < healthParameter.Min)
                impact = (healthParameter.Current - healthParameter.Min) / 100;
            else
                impact = 0.00;
            return impact;
        }
        public double TotalImpactOnLife()
        {
            double totalImpactonlife =
                (HealthParameterImpact(totalDissolvedSolids) * 3 + HealthParameterImpact(heat) * 4  + HealthParameterImpact(oxygenAmount) * 5 +
                HealthParameterImpact(Overcrowding) * 1 + HealthParameterImpact(noiseLevel) * 1.5 + HealthParameterImpact(airQualityIndex) * 2);
            return totalImpactonlife;
        }
        public override string ToString()
        {  
            List<HealthParameters<double>> healthParameters = new List<HealthParameters<double>>()
            {totalDissolvedSolids ,heat, oxygenAmount, Overcrowding, noiseLevel, airQualityIndex };
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in healthParameters)
            {
                stringBuilder.AppendLine($"{item.Name}: {HealthParameterImpact(item)}");
            }
            return stringBuilder.ToString();
        }
    }
}
