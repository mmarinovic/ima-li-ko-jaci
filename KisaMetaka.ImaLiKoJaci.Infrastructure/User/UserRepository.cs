﻿using System;
using System.Linq;
using KisaMetaka.ImaLiKoJaci.Infrastructure.Data;

namespace KisaMetaka.ImaLiKoJaci.Infrastructure.User
{
    public class UserRepository : IUserRepository
    {
        private readonly DataModel _context;

        public UserRepository(DataModel context)
        {
            _context = context;
        }

        public void Create(string displayName, string facebookId)
        {
            if (string.IsNullOrWhiteSpace(displayName)) { throw new ArgumentException("displayName"); }
            if (string.IsNullOrWhiteSpace(facebookId)) { throw new ArgumentException("facebookId"); }

            var user = new Data.User
            {
                DisplayName = displayName,
                FacebookId = facebookId,
                JoinedOn = DateTime.Now,
                TotalScore = 0
            };

            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public UserDto TryGet(string facebookId)
        {
            if (string.IsNullOrWhiteSpace(facebookId)) { throw new ArgumentException("facebookId"); }

            var user = _context.Users.SingleOrDefault(x => x.FacebookId == facebookId);
            if (user == null) { return null; }

            return new UserDto(user);
        }
    }
}
