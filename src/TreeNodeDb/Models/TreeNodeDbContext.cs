using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreeNodeDb.Models
{
    public class TreeNodeDbContext : DbContext
    {
        public DbSet<Node> Nodes { get; set; }

        public TreeNodeDbContext(DbContextOptions<TreeNodeDbContext> options) : base(options)
        {

        }
    }
}
