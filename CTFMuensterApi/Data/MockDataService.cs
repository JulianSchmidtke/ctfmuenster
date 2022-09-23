
using System;
using System.Collections.Generic;
using System.Linq;
using CTFMuenster.Api.Model;

namespace CTFMuensterApi.Data {

    public class MockDataService : IDataService {

        private DummyData data;

        public MockDataService()
        {
            data = new DummyData();
        }

        public User GetUser(Guid id) {
            return data.MockUsers.First(x => x.Id == id);
        }

        public IEnumerable<User> GetUsers() {
            return data.MockUsers;
        }

        public Flag GetFlag(Guid id) {
            return data.MockFlags.First(x => x.Id == id);
        }

        public IEnumerable<Flag> GetFlags() {
            return data.MockFlags;
        }

        public IEnumerable<UserFlag> GetFlagsPerUser(Guid userId) {
            return data.MockUserFlags.Where(x => x.User.Id == userId);
        }

        public IEnumerable<UserFlag> GetFlagsPerUser(Guid userId, Guid flagId)
        {
            return data.MockUserFlags.Where(x => x.User.Id == userId && x.Flag.Id == flagId);
        }

        public IEnumerable<UserFlag> GetUsersPerFlag(Guid flagId)
        {
            return data.MockUserFlags.Where(x => x.Flag.Id == flagId);
        }

        public IEnumerable<UserFlag> GetUserFlags()
        {
            return data.MockUserFlags;
        }

        public UserFlag CreateUserFlag(UserFlag userFlag)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserFlag> GetPoints(int maxUsers, DateTimeOffset minimumDate, DateTimeOffset maximumDate)
        {
            if(maxUsers < 1) {
                throw new ArgumentOutOfRangeException();
            }
            return data.MockUserFlags.Where(x => x.DateTimeCollected > minimumDate && x.DateTimeCollected < maximumDate).Chunk(maxUsers).FirstOrDefault(Array.Empty<UserFlag>());
        }

    }


    internal class DummyData {

        internal readonly Flag[] MockFlags;
        internal readonly User[] MockUsers;
        internal readonly UserFlag[] MockUserFlags;

        internal DummyData() {
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
                    User=MockUsers[0],
                    Flag=MockFlags[0],
                    Score=10},
                new UserFlag(){
                    Id=new Guid(),
                    User=MockUsers[0],
                    Flag=MockFlags[1],
                    Score=20},
                new UserFlag(){
                    Id=new Guid(),
                    User=MockUsers[1],
                    Flag=MockFlags[1],
                    Score=50},
            };
        }
    }
}
