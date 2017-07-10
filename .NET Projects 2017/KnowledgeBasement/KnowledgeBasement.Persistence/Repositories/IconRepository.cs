using KnowledgeBasement.Persistence.Entities;
using KnowledgeBasement.Persistence.Repositories.Base;
using PetaPoco.NetCore;

namespace KnowledgeBasement.Persistence.Repositories
{
    public class IconRepository : BaseRepository<Icon>
    {
        public IconRepository(Database database, string tableName) : base(database, tableName)
        {
        }
    }
}