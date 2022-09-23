using System;

namespace CTFMuenster.Api.Model
{
    public class UserFlag {
        public Guid Id {get; set;}
        public User User {get; set;}
        public Flag Flag {get; set;}
        public int Score {get; set;}
        public DateTimeOffset DateTimeCollected {get; set;}
    }
}

