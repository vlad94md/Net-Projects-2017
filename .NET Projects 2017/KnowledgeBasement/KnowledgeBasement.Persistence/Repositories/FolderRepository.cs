using KnowledgeBasement.Persistence.Entities;
using KnowledgeBasement.Persistence.Repositories.Base;
using PetaPoco.NetCore;

namespace KnowledgeBasement.Persistence.Repositories
{
    public class FolderRepository : BaseRepository<Folder>
    {
        public FolderRepository(Database database, string tableName) : base(database, tableName)
        {
        }
    }
}