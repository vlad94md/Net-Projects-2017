using System;
using System.Collections.Generic;
using System.Linq;
using KnowledgeBasement.Persistence.Entities;
using KnowledgeBasement.Persistence.Repositories;
using PetaPoco.NetCore;

namespace KnowledgeBasement.Persistence.Context
{
    public class UnitOfWork : IDisposable
    {
        private readonly Database _database;
        public UnitOfWork(string connectionString)
        {
            _database = DatabaseContext.GetDatabase(connectionString);
        }

        private UserRepository _users;

        public UserRepository Users => _users ?? new UserRepository(_database, "Users");
        //public List<Project> Projects => _database.Query<Project>(Sql.Builder.Append("select * from Projects")).ToList();
        //public List<Article> Articles => _database.Query<Article>(Sql.Builder.Append("select * from Articles")).ToList();
        //public List<Folder> Folders => _database.Query<Folder>(Sql.Builder.Append("select * from Folders")).ToList();
        //public List<Icon> Icons => _database.Query<Icon>(Sql.Builder.Append("select * from Projects")).ToList();
        //public List<Category> Categories => _database.Query<Category>(Sql.Builder.Append("select * from Categories")).ToList();

        public void Dispose()
        {
            _database.Dispose();
        }
    }
}
