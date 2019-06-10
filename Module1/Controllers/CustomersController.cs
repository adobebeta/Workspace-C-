using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        static List<Customer> _customers = new List<Customer>()
        {
            new Customer() { Id=0 , Name= "Andrew",  Email ="andrew@gmail.com" , Phone = "555"},
            new Customer() { Id=1 , Name= "Tom",  Email ="tom@gmail.com" , Phone = "111"}
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_customers);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Customer customer)
        {
            _customers.Add(customer);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}