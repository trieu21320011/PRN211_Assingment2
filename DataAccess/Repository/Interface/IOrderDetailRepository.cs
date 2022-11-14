using BusinessObject;

namespace DataAccess.Repository.Interface
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetailByOrderID(int orderID);
        OrderDetail GetOrderDetailByProductID(int productID);
        void InsertOrderDetail(OrderDetail orderDetail);
        void UpdateOrderDetail(OrderDetail orderDetail);
        void DeleteOrderDetail(int orderDetailID);
    }
}
