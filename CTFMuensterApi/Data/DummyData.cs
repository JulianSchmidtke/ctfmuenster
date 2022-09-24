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
                        MockTags.Where(x => x.Name.Equals("history")).First()
                    },
                    DateTimeStartActive = new DateTimeOffset(2022,08,23,12,0,0,TimeSpan.Zero),
                    DateTimeEndActive = new DateTimeOffset(2022,08,23,23,59,59,TimeSpan.Zero)
                },
                new Flag(){
                    Id=new Guid("76d4fc1a-643c-4ec7-a876-a14cdec0980c"),
                    Description="Buddenturm",
                    FlagName="Buddenturm",
                    Location= new Location(51.96626699838519, 7.623065882679778),
                    Tags= new Tag[]{
                        MockTags.Where(x => x.Name.Equals("history")).First()
                    },
                    DateTimeStartActive = new DateTimeOffset(2022,08,22,0,0,0,TimeSpan.Zero),
                    DateTimeEndActive = new DateTimeOffset(2022,08,22,23,59,59,TimeSpan.Zero)
                },
                new Flag(){
                    Id=new Guid("ba529460-c0a1-428d-9239-9ae3442e18fb"),
                    Description="Davidwache",
                    FlagName="Davidwache",
                    Location= new Location(51.96646017686706, 7.6182496299172575),
                    Tags= new Tag[]{
                        MockTags.Where(x => x.Name.Equals("party")).First()
                    },
                    DateTimeStartActive = new DateTimeOffset(2022,08,20,0,0,0,TimeSpan.Zero),
                    DateTimeEndActive = new DateTimeOffset(2022,08,20,23,59,59,TimeSpan.Zero)
                },
                new Flag(){
                    Id=new Guid("1b2eda74-1053-495d-a88d-748fb093aa70"),
                    Description="Schloss",
                    FlagName="Schloss",
                    Location= new Location(51.963522387472324, 7.614137158901378),
                    Tags= new Tag[]{
                        MockTags.Where(x => x.Name.Equals("history")).First()
                    },
                    DateTimeStartActive = new DateTimeOffset(2022,08,19,0,0,0,TimeSpan.Zero),
                    DateTimeEndActive = new DateTimeOffset(2022,08,19,23,59,59,TimeSpan.Zero)
                },
                new Flag(){
                    Id=new Guid("f479d87e-68dd-4b1c-97ca-f8157aac90ef"),
                    Description="Hafen",
                    FlagName="Hafen",
                    Location= new Location(51.95130983077973, 7.638806055037238),
                    Tags= new Tag[]{
                        MockTags.Where(x => x.Name.Equals("party")).First()
                    }
                },
                new Flag(){
                    Id=new Guid("5b6b9b4e-e58c-408a-91b3-bf8504978f38"),
                    Description="Flugplatz Münster-Handorf",
                    FlagName="Flugplatz Münster-Handorf",
                    Location= new Location(51.995277777778, 7.7319444444444),
                    Tags= new Tag[]{
                        MockTags.Where(x => x.Name.Equals("history")).First()
                    },
                    DateTimeStartActive = new DateTimeOffset(2022,09,22,0,0,0,TimeSpan.Zero),
                    DateTimeEndActive = new DateTimeOffset(2022,09,22,23,59,59,TimeSpan.Zero)
                },
                new Flag(){
                    Id=new Guid("d87c0120-31ba-4a77-8af5-417729362f75"),
                    Description="St.-Paulus-Dom",
                    FlagName="St.-Paulus-Dom",
                    Location= new Location(51.96296072682899, 7.625782327779225),
                    Tags= new Tag[]{
                        MockTags.Where(x => x.Name.Equals("history")).First()
                    },
                    DateTimeStartActive = new DateTimeOffset(2022,09,24,0,0,0,TimeSpan.Zero),
                    DateTimeEndActive = new DateTimeOffset(2022,09,24,23,59,59,TimeSpan.Zero)
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
                new User(){
                    Id=new Guid("2d1782d9-59de-4cff-9014-e79045cabfc2"),
                    UserName="Manfred"},
                new User(){
                    Id=new Guid("a59ed73d-20be-458d-bd31-da4aabbeb1d2"),
                    UserName="Katharina"},
                new User(){
                    Id=new Guid("b25314c6-d399-4827-a9c3-ac403abaabd3"),
                    UserName="Olaf"},
                new User(){
                    Id=new Guid("000c26b2-a9cc-49bf-9705-fffbb47e4cee"),
                    UserName="Wladimir"},
                new User(){
                    Id=new Guid("90d31f13-0fcf-428a-a8e4-65a69f9cc250"),
                    UserName="Boris"},
                new User(){
                    Id=new Guid("216e480e-3664-4d8c-b5a6-a358edc4cf53"),
                    UserName="Donald"},

            };

        MockUserFlags = new List<UserFlag>
            {
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[0].Id,
                    FlagId=MockFlags[0].Id,
                    DateTimeCollected = new DateTimeOffset(2022,08,23,13,0,0,TimeSpan.Zero),
                    Score=1000},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[1].Id,
                    FlagId=MockFlags[0].Id,
                    DateTimeCollected = new DateTimeOffset(2022,08,23,14,0,0,TimeSpan.Zero),
                    Score=950},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[2].Id,
                    FlagId=MockFlags[0].Id,
                    DateTimeCollected = new DateTimeOffset(2022,08,23,15,0,0,TimeSpan.Zero),
                    Score=900},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[3].Id,
                    FlagId=MockFlags[0].Id,
                    DateTimeCollected = new DateTimeOffset(2022,08,23,16,0,0,TimeSpan.Zero),
                    Score=850},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[4].Id,
                    FlagId=MockFlags[0].Id,
                    DateTimeCollected = new DateTimeOffset(2022,08,23,17,0,0,TimeSpan.Zero),
                    Score=800},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[5].Id,
                    FlagId=MockFlags[0].Id,
                    DateTimeCollected = new DateTimeOffset(2022,08,23,18,0,0,TimeSpan.Zero),
                    Score=750},
                


                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[4].Id,
                    FlagId=MockFlags[5].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,22,12,0,0,TimeSpan.Zero),
                    Score=1000},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[5].Id,
                    FlagId=MockFlags[5].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,22,12,0,0,TimeSpan.Zero),
                    Score=950},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[6].Id,
                    FlagId=MockFlags[5].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,22,12,0,0,TimeSpan.Zero),
                    Score=900},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[7].Id,
                    FlagId=MockFlags[5].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,22,12,0,0,TimeSpan.Zero),
                    Score=850},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[8].Id,
                    FlagId=MockFlags[5].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,22,12,0,0,TimeSpan.Zero),
                    Score=800},

                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[5].Id,
                    FlagId=MockFlags[6].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,24,11,0,0,TimeSpan.Zero),
                    Score=1000},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[4].Id,
                    FlagId=MockFlags[6].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,24,11,0,0,TimeSpan.Zero),
                    Score=950},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[3].Id,
                    FlagId=MockFlags[6].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,24,11,0,0,TimeSpan.Zero),
                    Score=900},
                new UserFlag(){
                    Id=new Guid(),
                    UserId=MockUsers[2].Id,
                    FlagId=MockFlags[6].Id,
                    DateTimeCollected = new DateTimeOffset(2022,09,24,11,0,0,TimeSpan.Zero),
                    Score=850},
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

    public Flag AddFlag(Flag flag)
    {
        MockFlags.Add(flag);
        return flag;
    }
}
