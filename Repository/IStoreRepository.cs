using AspNetCoreSample.Models;
using System.Collections.Generic;

namespace AspNetCoreSample.Repository
{
    public interface IStoreRepository
    {
        List<Product> GetProducts();

        List<Product> GetFeaturedProducts();
    }
}