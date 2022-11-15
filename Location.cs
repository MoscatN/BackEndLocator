using System.ComponentModel.DataAnnotations;

namespace LocatorBackEnd
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public Double Latitude { get; set; }
        public Double Longitude { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Locality { get; set; }
        public string Region { get; set; }

    }
}