using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [Route("api/Products")]
    [ApiController]
    public class Products2Controller : ControllerBase
    {
        static List<Products> _products = new List<Products>() {
            new Products() {ProductId = 0 , ProductName = "Lapbtop" , ProductPrice = "100"},
            new Products() {ProductId = 2 , ProductName = "Zoommo" , ProductPrice = "1000"},
            new Products() {ProductId = 1 , ProductName = "SmartHome" , ProductPrice = "200"}
            };

        //public IEnumerable<Products> Get()
        //{
        //    return _products;
        //}

         [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(_products);
        }

        [HttpGet("LoadWelcomMessage")]
        public IActionResult GetWelcomeMessage()
        {
            return Ok("Welcome to our store");
        }

        [HttpPost] //pass
        public IActionResult Post([FromBody]Products products)
        {
            _products.Add(products);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")] //pass
        public void Put(int id,[FromRoute]Products products)
        {
            _products[id] = products;
        }

        [HttpDelete("{id}")] //pass
        public void Delete(int id, [FromBody]Products products)
        {
            _products.RemoveAt(id);
        }
    
    }
}