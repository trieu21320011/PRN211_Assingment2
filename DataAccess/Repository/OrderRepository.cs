using BusinessObject;
using DataAccess.DAO;
using DataAccess.Repository.Interface;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> GetOrders() => OrderDAO.Instance.GetOrderList();
        public List<Order> GetOrderByMemberID(int memberID) => OrderDAO.Instance.GetOrderByMemberID(memberID);
        public void DeleteOrder(int orderID) => OrderDAO.Instance.Remove(orderID);

        //public OrderObject GetOrderByID(int orderID) => OrderDAO.Instance.GetOrderByID(orderID);
        //public List<Object> GetOrderListTotalByID(DateTime StartDate, DateTime EndDate) => OrderDAO.Instance.GetOrderListTotalByID(StartDate,EndDate);
        //public void InsertOrder(OrderObject order) => OrderDAO.Instance.AddNew(order);
        //public void UpdateOrder(OrderObject order) => OrderDAO.Instance.Update(order);
    }
}
