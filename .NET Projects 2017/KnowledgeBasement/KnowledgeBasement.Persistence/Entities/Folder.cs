using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnowledgeBasement.Persistence.Entities.Constants;

namespace KnowledgeBasement.Persistence.Entities
{
    public class Folder
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ParentItemId { get; set; }
        public FolderType Type { get; set; }
        public Guid OwnerId { get; set; }
        public Guid CategoryId { get; set; }
    }
}