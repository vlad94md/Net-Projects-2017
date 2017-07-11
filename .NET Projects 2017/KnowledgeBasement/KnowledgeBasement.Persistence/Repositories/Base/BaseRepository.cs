using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnowledgeBasement.Persistence.Entities;
using PetaPoco.NetCore;

namespace KnowledgeBasement.Persistence.Repositories.Base
{
    public abstract class BaseRepository<T> : IGenericRepository<T>
    {
        private readonly Database _database;
        private readonly string tableName;

        protected BaseRepository(Database database, string tableName)
        {
            _database = database;
            this.tableName = tableName;
        }

        public List<T> GetAll()
        {
            return _database.Query<T>(Sql.Builder.Append($"select * from {tableName}")).ToList();
        }

        public bool Insert(T entity)
        {
            return (bool)_database.Insert(tableName, "Id", false, entity);
        }

        public int Update(T entity)
        {
            return _database.Update<T>(tableName, "Id", entity);
        }

        public int Delete(object id)
        {
            return _database.Delete<T>(id);
        }

        public T Get(object id)
        {
            return _database.SingleOrDefault<T>(id);
        }

        public T InsertWithIncrement(T entity)
        {
            return (T)_database.Insert(tableName, "Id", true, entity);
        }
    }
}
