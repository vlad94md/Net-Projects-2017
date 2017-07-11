using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using KnowledgeBasement.Persistence.Context;
using KnowledgeBasement.Persistence.Entities;
using KnowledgeBasement.Services.Abstract;

namespace KnowledgeBasement.Services.Implement
{
    public class UserService : IUserService
    {
        public void RegisterNewUser(AppUser user)
        {
            using (var db = new UnitOfWork(ConnectionStrings.Default))
            {
                user.Id = Guid.NewGuid();
                db.Users.Insert(user);
            }
        }

        public bool IsUsernameAndPasswordCorrect(string username, string password)
        {
            using (var db = new UnitOfWork(ConnectionStrings.Default))
            {
                var users = db.Users.GetAll();

                return users.FirstOrDefault(x => x.Username == username && x.Password == password) != null;
            }
        }

        public bool CheckUsernameIsUnique(string username)
        {
            using (var db = new UnitOfWork(ConnectionStrings.Default))
            {
                var users = db.Users.GetAll();

                return users.FirstOrDefault(x => x.Username == username) == null;
            }
        }
    }
}
