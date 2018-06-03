using System;
namespace CrossSolar.Models
{
    public class OneDayElectricityModel
    {
        //wanted
        public double Sum { get; set; }
        public double Minimum { get; set; }
        public double Maximum { get; set; }
        public double Average { get; set; }
        public DateTime DateTime { get; set; }
    }
}
