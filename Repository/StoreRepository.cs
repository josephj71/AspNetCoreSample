using AspNetCoreSample.Models;
using AspNetCoreSample.ServiceProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreSample.Repository
{
    public class StoreRepository : IStoreRepository
    {
        private OnlineStoreContext StoreContext;
        public StoreRepository(OnlineStoreContext context)
        {
            StoreContext = context;
        }

        public List<Product> GetProducts()
        {
            return StoreContext.Products.ToList();
        }

        public List<Product> GetFeaturedProducts()
        {
            return StoreContext.Products.Where(p => p.Featured).ToList();
        }
    }
}
