using System;
using System.ComponentModel.DataAnnotations;

namespace CTFMuenster.Api.Model
{
    public class User {
        [Key]
        public Guid Id {get; set;}
        public String UserName {get; set;}
    }
}