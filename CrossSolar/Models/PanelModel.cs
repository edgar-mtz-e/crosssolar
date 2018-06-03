using System.ComponentModel.DataAnnotations;

namespace CrossSolar.Models
{
    public class PanelModel
    {
        public int Id { get; set; }


        //latitude/longitude contains 6 decimal places.
        [Required]
        [Range(-90, 90)]
        [RegularExpression(@"^\d+(\.\d{6})$")]
        public double Latitude { get; set; }

      
        [Range(-180, 180)]
        [RegularExpression(@"^\d+(\.\d{6})$")]
        public double Longitude { get; set; }

        //serial number must be 16 characters length
        [Required]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Serial has to be 16 characters long")]
        public string Serial { get; set; }

        
        public string Brand { get; set; }

    }
}
