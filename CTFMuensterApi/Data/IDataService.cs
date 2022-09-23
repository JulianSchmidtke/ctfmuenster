
using System;
using System.Collections.Generic;
using CTFMuenster.Api.Model;

namespace CTFMuensterApi.Data {
    public interface IDataService {
        public User GetUser(Guid id);

        public IEnumerable<User> GetUsers();

        public Flag GetFlag(Guid id);

        public Flag GetFlag(DateTimeOffset dateTimeOffset);

        public IEnumerable<Flag> GetFlags();

        public IEnumerable<UserFlag> GetFlagsPerUser(Guid userId);

        public IEnumerable<UserFlag> GetFlagsPerUser(Guid userId, Guid flagId);

        public IEnumerable<UserFlag> GetUsersPerFlag(Guid flagId);

        public UserFlag CreateUserFlag(UserFlag userFlag);
        
        public IEnumerable<UserFlag> GetPoints(int maxUsers, DateTimeOffset minimumDate, DateTimeOffset maximumDate);

        public IEnumerable<Score> GetScores(DateTimeOffset? since);
    }
}