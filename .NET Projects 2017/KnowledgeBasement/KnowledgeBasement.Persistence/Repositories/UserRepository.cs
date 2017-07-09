using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnowledgeBasement.Persistence.Entities;
using KnowledgeBasement.Persistence.Repositories.Base;
using PetaPoco.NetCore;

namespace KnowledgeBasement.Persistence.Repositories
{
    public class UserRepository : BaseRepository<AppUser>
    {
        public UserRepository(Database database, string tableName) : base(database, tableName)
        {
        }
    }
}
