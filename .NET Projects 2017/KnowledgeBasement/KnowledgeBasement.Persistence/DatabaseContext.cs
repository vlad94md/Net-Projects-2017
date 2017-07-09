using PetaPoco.NetCore;
using System.Data.SqlClient;

namespace KnowledgeBasement.Persistence
{
    public class DatabaseContext
    {
        public static Database GetDatabase(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            var db = new Database(connection);

            return db;
        }
    }
}
