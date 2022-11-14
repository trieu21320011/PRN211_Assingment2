using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Phong
{ 
    public interface IProductForCartRepository
    {
        void Update(Product product);
        bool checkQuantity(Product product);
        IEnumerable<Product> GetAll();
    }
}
