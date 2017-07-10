using KnowledgeBasement.Persistence.Entities;
using KnowledgeBasement.Persistence.Repositories.Base;
using PetaPoco.NetCore;

namespace KnowledgeBasement.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(Database database, string tableName) : base(database, tableName)
        {
        }
    }
}