using kitchentime.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;
using System.Web.Hosting;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Xml;

namespace kitchentime.web.Controllers
{
    public class ProductController : ApiController
    {


        // GET api/<controller>
        public HttpResponseMessage getProducts()
        {

            XElement xmlDoc = XElement.Load(HostingEnvironment.MapPath("~/App_Data/Products/products.xml"));

            var products =
            xmlDoc.Descendants("Product").Select(product => new Product
            {
                ProductName = product.Element("Name").Value,
                ProductShortDescription = product.Element("Header").Value,
                ProductDescription = product.Element("Description").Value,
                ProductImage = product.Element("ImageUrl").Value,
                ProductUrl = product.Element("ActionUrl").Value,

            });
            return new HttpResponseMessage()
            {
                Content = new StringContent(JArray.FromObject(products).ToString(), Encoding.UTF8, "application/json")
            };

        }
     }
}
