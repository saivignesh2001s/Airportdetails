using System.ComponentModel.DataAnnotations;

namespace Airportdetails.Models
{
    public class Dtoclass
    {
        public List<string> cities { get; set; }
        [Required]
        public string From
        {
            get;set;
        }
        [Required]
        public string To
        {
            get;set;
        }
      
    }
}
