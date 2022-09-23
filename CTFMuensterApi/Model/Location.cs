using System.ComponentModel.DataAnnotations;
namespace CTFMuenster.Api.Model{
    public class Location {
        [Key]
        public Guid Id {get; set;}
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}