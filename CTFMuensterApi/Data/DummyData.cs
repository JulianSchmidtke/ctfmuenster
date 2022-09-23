using CTFMuenster.Api.Model;
using CTFMuensterApi.Data;

public class DummyData : IDataRepository
    {

        internal readonly Flag[] MockFlags;
        internal readonly User[] MockUsers;
        internal readonly UserFlag[] MockUserFlags;

        public DummyData()
        {
            MockFlags = new[]
            {
                new Flag(){
                    Id=new Guid("d404eed3-5842-4d45-84b5-dce00b015dac"),
                    Description="Prinzipalmarkt",
                    FlagName="Prinzipalmarkt",
                    Location= new Location(51.962776004909124, 7.6282566472538615),
                    Tags= Array.Empty<Tag>()},
                new Flag(){
                    Id=new Guid("76d4fc1a-643c-4ec7-a876-a14cdec0980c"),
                    Description="Buddenturm",
                    FlagName="Buddenturm",
                    Location= new Location(51.96626699838519, 7.623065882679778),
                    Tags=Array.Empty<Tag>()},
                new Flag(){
                    Id=new Guid("ba529460-c0a1-428d-9239-9ae3442e18fb"),
                    Description="Davidwache",
                    FlagName="Davidwache",
                    Location= new Location(51.96646017686706, 7.6182496299172575),
                    Tags=Array.Empty<Tag>()}
            };

            MockUsers = new[]
            {
                new User(){
                    Id=new Guid("e59871b2-5970-4f04-b1cd-42a0796a5279"),
                    UserName="Annabelle"},
                new User(){
                    Id=new Guid("62abdae3-6942-4460-9d47-06cb953de8fb"),
                    UserName="Bertha"},
                new User(){
                    Id=new Guid("90f2b715-b434-4362-b845-15397fa0a1dc"),
                    UserName="Christian"},
            };

            MockUserFlags = new[]
            {
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[0].Id,
                    FlagId=MockFlags[0].Id,
                    DateTimeCollected = new DateTimeOffset(2022,08,23,12,0,0,TimeSpan.Zero),
                    Score=10},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[0].Id,
                    FlagId=MockFlags[1].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,22,12,0,0,TimeSpan.Zero),
                    Score=20},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[1].Id,
                    FlagId=MockFlags[1].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,23,12,0,0,TimeSpan.Zero),
                    Score=50},
            };
        }

        public IEnumerable<Flag> GetFlags()
        {
            return MockFlags;
        }

        public IEnumerable<UserFlag> GetUserFlags()
        {
            return MockUserFlags;
        }

        public IEnumerable<User> GetUsers()
        {
            return MockUsers;
        }
    }