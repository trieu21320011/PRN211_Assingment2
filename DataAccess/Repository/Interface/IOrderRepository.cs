
using BusinessObject;

namespace DataAccess.Repository.Interface
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        List<Order> GetOrderByMemberID(int memberID);
        void DeleteOrder(int orderID);

        //List<Object> GetOrderListTotalByID(DateTime StartDate, DateTime EndDate);
        //OrderObject GetOrderByID(int orderID);
        //void InsertOrder(OrderObject order);
        //void UpdateOrder(OrderObject order);
    }
}
