using System;
using System.ComponentModel.DataAnnotations;

namespace CTFMuenster.Api.Model
{
    public class UserFlag {
        [Key]
        public Guid Id {get; set;}
        public Guid UserId {get; set;}
        public Guid FlagId {get; set;}
        public int Score {get; set;}
        public DateTimeOffset DateTimeCollected {get; set;}
    }
}

