using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using KnowledgeBasement.Persistence.Context;
using KnowledgeBasement.Persistence.Entities;

namespace KnowledgeBasement.Tests
{
    public class DatabaseTests
    {
        private UnitOfWork unitOfWork;
        public DatabaseTests()
        {
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=knowledgebasementdb;Trusted_Connection=True;MultipleActiveResultSets=true";
            unitOfWork = new UnitOfWork(connectionString);
        }

        [Fact]
        public void CreateEntity()
        {
            var newUser = new AppUser()
            {
                Id = new Guid(),
                Password = "12345",
                Username = "test_user",
                LastName = "LastName",
                FirstName = "FirstName"
            };

            var insertedUser = unitOfWork.Users.Insert(newUser);

            Assert.Equal(newUser, insertedUser);

            unitOfWork.Users.Delete(insertedUser.Id);
        }
    }
}
