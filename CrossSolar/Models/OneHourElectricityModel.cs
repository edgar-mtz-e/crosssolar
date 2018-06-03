using System;
using System.ComponentModel.DataAnnotations;

namespace CrossSolar.Models
{
    public class OneHourElectricityModel
    {
        public int Id { get; set; }

        [Required]
        public long KiloWatt { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        //added to debug
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{yyyy/MM/dd HH:mm:ss tt}")]
        public DateTime DateTime { get; set; }
    }
}
