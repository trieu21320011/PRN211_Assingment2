using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
namespace DataAccess.Repository
{
    public class ProductForCartRepository : IProductForCartRepository
    {
        private readonly Assignment2_PRN211Context _context;
        public ProductForCartRepository(Assignment2_PRN211Context context)
        {
            _context = context;
        }
        public void Update(Product product)
        {
            Product p = _context.Products.FirstOrDefault(x=> x.ProductId == product.ProductId);
            p.UnitStock -= product.UnitStock;
            _context.Update(p);
        }
        public bool checkQuantity(Product product)
        {
            var productInStock = _context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (productInStock.UnitStock < product.UnitStock) return false;
            return true;
        }
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
