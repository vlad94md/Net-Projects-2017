using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeBasement.Persistence.Entities
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ParentItemId { get; set; }
        public Guid OwnerId { get; set; }
        public Guid CategoryId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedOn { get; set; }
        public int IconId { get; set; }
    }
}