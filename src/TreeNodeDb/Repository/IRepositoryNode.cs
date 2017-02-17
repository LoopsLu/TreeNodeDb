using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreeNodeDb.Models;

namespace TreeNodeDb.Repository
{
    public interface IRepositoryNode
    {
        IEnumerable<Node> GetAll();
        void Create(Node entity);
        void Delete(string id);

        void SaveChanges();
    }
}
