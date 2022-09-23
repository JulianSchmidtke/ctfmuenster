using System;
using System.ComponentModel.DataAnnotations;

namespace CTFMuenster.Api.Model
{
    public class Score {
        [Key]
        public Guid Id {get; set;}
        public User User {get; set;}
        public int ScoreCount {get; set;}
        public int FlagCount {get; set;}
    }
}