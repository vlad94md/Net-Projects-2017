using System.Collections.Generic;

namespace KnowledgeBasement.Persistence.Repositories.Base
{
    public interface IGenericRepository<T>
    {
        List<T> GetAll();
        T Get(object id);
        bool Insert(T entity);
        int Update(T entity);
        int Delete(object id);

    }
}
