using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Data_Access_Layer.Models;

namespace Backend.Data_Access_Layer.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProductId);
        void InsertProduct(Product Product);
        void DeleteProduct(int  ProductId);
        void UpdateProduct(Product Product);
        void Save();
    }
}
