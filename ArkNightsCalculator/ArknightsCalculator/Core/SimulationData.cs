using System.Collections.Generic;

namespace ArknightsCalculator.Core
{
    public class SimulationData
    {
        public List<double> operatorDamageTotalData { get; set; }

        public List<double> operatorDPSTotalData { get; set; }

        public int enemyDefData { get; set; }

        public int enemyResData { get; set; }

        public string seriesName { get; set; }
    }
}
