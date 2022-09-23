using System;
using System.ComponentModel.DataAnnotations;

namespace CTFMuenster.Api.Model
{
    public class PostUserFlagRequest {
        [Key]
        public Guid Id {get; set;}
    }
}