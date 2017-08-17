using System;
using KnowledgeBasement.Persistence.Repositories;
using Microsoft.Extensions.Options;
using PetaPoco.NetCore;

namespace KnowledgeBasement.Persistence.Context
{
    public class UnitOfWork : IDisposable
    {
        private readonly Database _database;
        private readonly ConnectionStrings _settings;

        public UnitOfWork(IOptions<ConnectionStrings> settings)
        {
            _settings = settings.Value;
            _database = DatabaseContext.GetDatabase(_settings.DefaultConnection);
        }

        private UserRepository _users;
        private ProjectRepository _projects;
        private ArticleRepository _articles;
        private FolderRepository _folders;
        private IconRepository _icons;
        private CategoryRepository _categories;

        public UserRepository Users => _users ?? new UserRepository(_database, "Users");
        public ProjectRepository Projects => _projects ?? new ProjectRepository(_database, "Projects");
        public ArticleRepository Articles => _articles ?? new ArticleRepository(_database, "Articles");
        public FolderRepository Folders => _folders ?? new FolderRepository(_database, "Folders");
        public IconRepository Icons => _icons ?? new IconRepository(_database, "Icons");
        public CategoryRepository Categories => _categories ?? new CategoryRepository(_database, "Categories");

        public void Dispose()
        {
            _database.Dispose();
        }
    }
}
