using CTFMuenster.Api.Model;
using CTFMuensterApi.Data;

public class DummyData : IDataRepository
    {

        private List<Flag> MockFlags;
        private List<User> MockUsers;
        private List<UserFlag> MockUserFlags;

        private List<Tag> MockTags;

        public DummyData()
        {
            MockTags = new List<Tag>{
                new Tag(){
                            Id=new Guid("58b8d9d2-d3b5-42ec-a677-02bed9b27683"),
                            Name="history",
                            Description="Historical places in Muenster."
                        },
                new Tag(){
                            Id=new Guid("2af9d366-3219-4a2a-a729-36977ede3260"),
                            Name="sport",
                            Description="Places for people interested in sports."
                        },
                new Tag(){
                            Id=new Guid("41169a90-618d-4208-9fdf-ff180abd8e40"),
                            Name="party",
                            Description="Best places to get lost in Münsters after hour."
                        },
            };

            MockFlags = new List<Flag>
            {
                new Flag(){
                    Id=new Guid("d404eed3-5842-4d45-84b5-dce00b015dac"),
                    Description="Prinzipalmarkt",
                    FlagName="Prinzipalmarkt",
                    Location= new Location(51.962776004909124, 7.6282566472538615),
                    Tags= new Tag[]{
                        MockTags.First()// Where(x => x.Id.Equals("58b8d9d2-d3b5-42ec-a677-02bed9b27683")).First()
                    }
                },
                new Flag(){
                    Id=new Guid("76d4fc1a-643c-4ec7-a876-a14cdec0980c"),
                    Description="Buddenturm",
                    FlagName="Buddenturm",
                    Location= new Location(51.96626699838519, 7.623065882679778),
                    Tags= new Tag[]{
                        MockTags.First() //Where(x => x.Id.Equals("58b8d9d2-d3b5-42ec-a677-02bed9b27683")).First()
                    }
                },
                new Flag(){
                    Id=new Guid("ba529460-c0a1-428d-9239-9ae3442e18fb"),
                    Description="Davidwache",
                    FlagName="Davidwache",
                    Location= new Location(51.96646017686706, 7.6182496299172575),
                    Tags= new Tag[]{
                        MockTags.Last() //Where(x => x.Id.Equals("41169a90-618d-4208-9fdf-ff180abd8e40")).First()
                    }
                }
            };

            MockUsers = new List<User>
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

            MockUserFlags = new List<UserFlag>
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

    public UserFlag AddUserFlag(UserFlag userFlag)
    {
        MockUserFlags.Add(userFlag);
        return userFlag;
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