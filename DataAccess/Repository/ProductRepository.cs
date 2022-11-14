using BusinessObject;
using DataAccess.DAO;
using DataAccess.Repository.Interface;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProductList();
        public void DeleteProduct(int productID) => ProductDAO.Instance.Remove(productID);

        //public Product GetProductByID(int productID) => ProductDAO.Instance.GetProductByID(productID);
        //public void InsertProduct(ProductObject product) => ProductDAO.Instance.AddNew(product);
        //public void UpdateProduct(ProductObject product) => ProductDAO.Instance.Update(product);
    }
}
