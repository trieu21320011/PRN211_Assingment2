using BusinessObject;
using DataAccess.DAO;
using DataAccess.Repository.Interface;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetailList();
        public OrderDetail GetOrderDetailByOrderID(int orderID) => OrderDetailDAO.Instance.GetOrderDetailByOrderID(orderID);
        public OrderDetail GetOrderDetailByProductID(int productID) => OrderDetailDAO.Instance.GetOrderDetailByProductID(productID);
        public void InsertOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.AddNew(orderDetail);
        public void UpdateOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.Update(orderDetail);
        public void DeleteOrderDetail(int orderDetailID) => OrderDetailDAO.Instance.Remove(orderDetailID);
    }
}
