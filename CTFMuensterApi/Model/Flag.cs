namespace CTFMuenster.Api.Model
{
    public class Flag {
        public Guid Id {get; set;}
        public String FlagName {get; set;}
        public String Description {get; set;} 
        public Location Location {get; set;} 
        
        public Tag[] Tags {get; set;}
    }
    
}