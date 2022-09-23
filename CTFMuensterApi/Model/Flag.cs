namespace CTFMuenster.Api.Model
{
    public class Flag {
        public String FlagName {get; set;}
        public String Beschreibung {get; set;} 
        public String Ort {get; set;} 
        public Guid Id {get; set;}
        
        public Tag[] tags {get; set;}
    }
}