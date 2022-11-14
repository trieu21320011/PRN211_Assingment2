using BusinessObject;

namespace DataAccess.Repository.Interface
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void DeleteProduct(int productID);

        //ProductObject GetProductByID(int productID);
        //void InsertProduct(ProductObject product);
        //void UpdateProduct(ProductObject product);
    }
}
