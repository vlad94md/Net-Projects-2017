using System;

namespace KnowledgeBasement.Persistence.Entities
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid OwnerId { get; set; }
        public int IconId { get; set; }
    }
}