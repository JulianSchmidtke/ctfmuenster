using System;
using System.ComponentModel.DataAnnotations;

namespace CTFMuenster.Api.Model
{
    public class Tag {
        [Key]
        public Guid Id {get; set;}
        public String Name {get; set;}
        public String Description {get; set;} 
    }
}