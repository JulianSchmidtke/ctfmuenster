
using System;
using System.ComponentModel.DataAnnotations;
namespace CTFMuenster.Api.Model
{
    public class Flag {
        [Key]
        public Guid Id {get; set;}
        public String FlagName {get; set;}
        public String Description {get; set;} 
        public Location Location {get; set;} 
        public String ImageFileName {get; set;}
        public ICollection<Tag> Tags {get; set;}
        public DateTimeOffset DateTimeStartActive { get; set; }
        public DateTimeOffset DateTimeEndActive { get; set;}
    }   
}
