using System;

namespace CTFMuenster.Api.Model
{
    public class Score {
        public int Rang {get; set;}
        public User User {get; set;}
        public int ScoreCount {get; set;}
        public int FlagCount {get; set;}
    }
}