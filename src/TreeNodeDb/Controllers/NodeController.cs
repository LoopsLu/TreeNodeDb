using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TreeNodeDb.Models;
using TreeNodeDb.Repository;

namespace TreeNodeDb.Controllers
{
    [Route("api/[controller]")]
    public class NodeController : Controller
    {
        private IRepositoryNode _repository;
        public NodeController(IRepositoryNode repository)
        {
            _repository = repository;
        }

        // GET api/node
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(_repository.GetAll()); 
        }

        // POST api/node
        [HttpPost]
        public IActionResult Post([FromBody]Node node)
        {
            try
            {
                _repository.Create(node);
                _repository.SaveChanges();

                return new OkObjectResult("Success");
            }
            catch(Exception ex)
            {
                throw new InvalidOperationException("ParentId");
            }
            
        }
    }
}
