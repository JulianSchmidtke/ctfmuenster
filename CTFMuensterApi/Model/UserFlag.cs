using System;

namespace CTFMuenster.Api.Model
{
    public class UserFlag {
        public Guid Id {get; set;}
        public Guid UserId {get; set;}
        public Guid FlagId {get; set;}
        public int Score {get; set;}
        public DateTimeOffset DateTimeCollected {get; set;}
    }
}

