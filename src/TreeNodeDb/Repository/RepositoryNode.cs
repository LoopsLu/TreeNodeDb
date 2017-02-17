using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeNodeDb.Models;

namespace TreeNodeDb.Repository
{
    public class RepositoryNode : IRepositoryNode
    {
        private TreeNodeDbContext _dbContext;

        public RepositoryNode(TreeNodeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Node entity)
        {
            var node = new Node
            {
                NodeId = Guid.NewGuid().ToString(),
                Name = entity.Name,
                ParentId = entity.ParentId
            };

            _dbContext.Nodes.Add(node);
        }

        public void Delete(string id)
        {
            var node = _dbContext.Nodes.First(p => p.NodeId == id);

            _dbContext.Nodes.Remove(node);
        }

        public IEnumerable<Node> GetAll()
        {
            var result = _dbContext.Nodes;
            return result;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
