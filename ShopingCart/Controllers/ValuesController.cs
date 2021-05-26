using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopingCart.Model;
using ShopingCart.Services;

namespace ShopingCart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IUserRepo _UserRepo;

        public ValuesController(IUserRepo UserRepo)
        {
            _UserRepo = UserRepo;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
           var custDetails = _UserRepo.GetCustomerOrderDetails(id);
            return Ok(custDetails);

        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            var u = new List<User>();
            u.Add(user);
            return Ok();
        }
       
    }
}
