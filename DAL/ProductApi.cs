using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace DAL
{
    public class ProductApi
    {
        private RestClient client;
        private string token;

        public ProductApi(string url, string token) 
        {
            this.token = token;
            client = new RestClient();
            client.BaseUrl = url;
        }

        public T Execute<T>(RestRequest req) where T : new()
        {
            req.AddParameter("token", token, ParameterType.GetOrPost);
            var res = client.Execute<T>(req);
            return res.Data;
        }

        /// <summary>
        /// Get product data
        /// </summary>
        /// <param name="id">Product Id</param>
        /// <returns>Product</returns>
        public Product GetProduct(string id)
        {
            var request = new RestRequest("sup/product/view/{id}");
            request.AddUrlSegment("id", id);
            return Execute<Product>(request);
        }

        public bool AddProduct(Product p)
        {
            throw new NotImplementedException();
        }

        public bool RemoveProduct(string id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(string id)
        {
            throw new NotImplementedException();
        }
    }
}
