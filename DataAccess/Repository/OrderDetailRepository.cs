using BusinessObject;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetailList();

        //public OrderDetail GetOrderDetailByOrderID(int orderID) => OrderDetailDAO.Instance.GetOrderDetailByID(orderID);

        //public OrderDetailObject GetOrderDetailByProductID(int productID) => OrderDetailDAO.Instance.GetOrderDetailByProductID(productID);

        //public IEnumerable<OrderDetailObject> GetOrderDetailsByOrderID(int orderID) => OrderDetailDAO.Instance.GetOrderDetailListByOrderID(orderID);

        //public void InsertOrderDetail(OrderDetailObject orderDetail) => OrderDetailDAO.Instance.AddNew(orderDetail);

        //public void UpdateOrderDetail(OrderDetailObject orderDetail) => OrderDetailDAO.Instance.Update(orderDetail);

        //public void DeleteOrderDetail(int orderDetailID) => OrderDetailDAO.Instance.Remove(orderDetailID);
    }
}
