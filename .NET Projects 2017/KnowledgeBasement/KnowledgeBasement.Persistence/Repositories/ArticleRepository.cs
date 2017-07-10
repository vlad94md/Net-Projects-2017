using KnowledgeBasement.Persistence.Entities;
using KnowledgeBasement.Persistence.Repositories.Base;
using PetaPoco.NetCore;

namespace KnowledgeBasement.Persistence.Repositories
{
    public class ArticleRepository : BaseRepository<Article>
    {
        public ArticleRepository(Database database, string tableName) : base(database, tableName)
        {
        }
    }
}