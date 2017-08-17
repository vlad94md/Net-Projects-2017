using System;
using System.Linq;
using KnowledgeBasement.Persistence.Context;
using KnowledgeBasement.Persistence.Entities;
using KnowledgeBasement.Services.Abstract;
using Microsoft.Extensions.Options;

namespace KnowledgeBasement.Services.Implement
{
    public class UserService : IUserService
    {
        private readonly UnitOfWork db;

        public UserService(UnitOfWork unitOfWork)
        {
            db = unitOfWork;
        }

        public void RegisterNewUser(AppUser user)
        {
            user.Id = Guid.NewGuid();
            db.Users.Insert(user);
        }

        public bool IsUsernameAndPasswordCorrect(string username, string password)
        {
            var users = db.Users.GetAll();

            return users.FirstOrDefault(x => x.Username == username && x.Password == password) != null;
        }

        public bool CheckUsernameIsUnique(string username)
        {
            var users = db.Users.GetAll();

            return users.FirstOrDefault(x => x.Username == username) == null;
        }
    }
}
