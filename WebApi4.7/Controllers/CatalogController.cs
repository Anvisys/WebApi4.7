using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApi4._7.Models;

namespace WebApi4._7.Controllers
{
    public class CatalogController : ApiController
    {
        List<Product> productList = new List<Product>();

        public CatalogController()
        {
            productList.Add(new Product { ProductId = 1, ProductCategory = "Book", ProductName = "The Fountain Head" });
            productList.Add(new Product { ProductId = 2, ProductCategory = "Book", ProductName = "Atlas Shrugged" });
            productList.Add(new Product { ProductId = 3, ProductCategory = "Kitchen", ProductName = "Food Processor" });
            productList.Add(new Product { ProductId = 4, ProductCategory = "Kitchen", ProductName = "Food Processor" });
        }



        // GET: api/Catalog
        public IEnumerable<Product> Get()
        {
            return productList;
        }

        // GET: api/Catalog/5
        public Product Get(int id)
        {
            return productList.Find(p=> p.ProductId == id);
        }

        // POST: api/Catalog
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Catalog/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Catalog/5
        public void Delete(int id)
        {
        }
    }
}
