using MIPChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIPChat.DAL.Repository
{
    public class UserRepository : BaseRepository<ChatDBContext, User>, IUsersRepository
    {
        public UserRepository(ChatDBContext context) : base(context)
        {
        }

        public Task<User> FindUserByEmail(string Email)
        {
            return _dbSet.FindAsync(Email);
        }

        public async bool PasswordCheck(LoginModel input)
        {
            User check = FindUserByEmail(input.Email);
            if (check.RegisterModel.Password == input.Password)
            {
                return true;
            }
        }
    }
}