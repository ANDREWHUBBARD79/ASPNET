using Testing.Models;

namespace Testing.Controllers
{
    internal interface IProductRepo
    {
        string GetAllProducts();
        Product GetProduct(int id);
    }
}