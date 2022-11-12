using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails();
        //IEnumerable<OrderDetail> GetOrderDetailsByOrderID(int orderID);
        //OrderDetail GetOrderDetailByOrderID(int orderDetail);
        //OrderDetail GetOrderDetailByProductID(int productID);
        //void InsertOrderDetail(OrderDetail orderDetail);
        //void DeleteOrderDetail(int orderDetailID);
        //void UpdateOrderDetail(OrderDetail orderDetail);
    }
}
