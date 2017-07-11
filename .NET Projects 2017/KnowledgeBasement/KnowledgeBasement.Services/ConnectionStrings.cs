namespace KnowledgeBasement.Services
{
    public static class ConnectionStrings
    {
        public static string Default { get; } = "Server=(localdb)\\MSSQLLocalDB;Database=knowledgebasementdb;Trusted_Connection=True;MultipleActiveResultSets=true";
        //public static string Default { get; } = "Server=tcp:vguleaevdatabase.database.windows.net,1433;Initial Catalog=knowledgebasementdb;Persist Security Info=False;User ID=vguleaev;Password=Databasepass1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
}
