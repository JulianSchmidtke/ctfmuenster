
using System;
using System.Collections.Generic;
using System.Linq;
using CTFMuenster.Api.Model;

namespace CTFMuensterApi.Data
{

    public class DataService : IDataService
    {
        private IDataRepository data;

        public DataService(IDataRepository dataRepository)
        {
            data = dataRepository;
        }

        public User GetUser(Guid id)
        {
            return data.GetUsers().First(x => x.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return data.GetUsers();
        }

        public Flag GetFlag(Guid id)
        {
            return data.GetFlags().First(x => x.Id == id);
        }

        public IEnumerable<Flag> GetFlag(DateTimeOffset dateTimeOffset)
        {
            return data.GetFlags().Where(x => dateTimeOffset > x.DateTimeStartActive && dateTimeOffset < x.DateTimeEndActive);
        }

        public IEnumerable<Flag> GetFlags()
        {
            return data.GetFlags();
        }

        public IEnumerable<UserFlag> GetFlagsPerUser(Guid userId)
        {
            return data.GetUserFlags().Where(x => x.UserId == userId);
        }

        public IEnumerable<UserFlag> GetFlagsPerUser(Guid userId, Guid flagId)
        {
            return data.GetUserFlags().Where(x => x.UserId == userId && x.FlagId == flagId);
        }

        public IEnumerable<UserFlag> GetUsersPerFlag(Guid flagId)
        {
            return data.GetUserFlags().Where(x => x.FlagId == flagId);
        }

        public IEnumerable<UserFlag> GetUserFlags()
        {
            return data.GetUserFlags();
        }

        public UserFlag CreateUserFlag(UserFlag userFlag)
        {
            return data.AddUserFlag(userFlag);
        }

        public IEnumerable<UserFlag> GetPoints(int maxUsers, DateTimeOffset minimumDate, DateTimeOffset maximumDate)
        {
            if (maxUsers < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            return data.GetUserFlags().Where(x => x.DateTimeCollected > minimumDate && x.DateTimeCollected < maximumDate).Chunk(maxUsers).FirstOrDefault(Array.Empty<UserFlag>()).OrderBy(x => x.Score); // zweite sortierung nach datum oder alphabet
        }

        Flag IDataService.GetFlag(DateTimeOffset dateTimeOffset)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Score> GetScores(DateTimeOffset? since)
        {
            var userflags = data.GetUserFlags();
            if (since != null)
            {

                userflags = userflags.Where(x => since <= x.DateTimeCollected).ToArray();
            }

            return userflags.GroupBy(x => x.UserId).Select(u => new Score()
            {
                User = data.GetUsers().Where(user=> user.Id == u.Key).First(),
                ScoreCount = u.Sum(s => s.Score),
                FlagCount = u.Count()
            }).OrderByDescending(x => x.ScoreCount);
        }

        public Flag AddFlag(Flag flag)
        {
            return data.AddFlag(flag);
        }
    }
}
