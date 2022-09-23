namespace CTFMuenster.Api.Model
{
    public class Tag {
        public String name {get; set;}
        public String Beschreibung {get; set;} 
        public Guid Id {get; set;}
        public Flag[] flags {get; set;}
    }
}