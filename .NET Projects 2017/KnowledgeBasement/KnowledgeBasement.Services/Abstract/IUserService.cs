using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnowledgeBasement.Persistence.Entities;

namespace KnowledgeBasement.Services.Abstract
{
    public interface IUserService
    {
        void RegisterNewUser(AppUser user);

        bool IsUsernameAndPasswordCorrect(string username, string password);

        bool CheckUsernameIsUnique(string username);
    }
}
