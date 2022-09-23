
using System;
using System.Collections.Generic;
using CTFMuenster.Api.Model;

namespace CTFMuensterApi.Data {
    public interface IDataRepository {
        public IEnumerable<User> GetUsers();

        public IEnumerable<Flag> GetFlags();
        public IEnumerable<UserFlag> GetUserFlags();

        public UserFlag AddUserFlag(UserFlag userFlag);

    }
}