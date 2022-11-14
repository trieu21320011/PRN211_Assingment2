using BusinessObject;

namespace DataAccess.DAO
{
    public class OrderDetailDAO : Assignment2_PRN211Context
    {

        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null) instance = new OrderDetailDAO();
                    return instance;
                }
            }
        }

        //private static List<OrderDetailObject> OrderDetailList = new List<OrderDetailObject>();

        public IEnumerable<OrderDetail> GetOrderDetailList() => OrderDetails.ToArray();

        public OrderDetail GetOrderDetailByOrderID(int OrderID)
            => OrderDetails.Where(od => od.OrderId.Equals(OrderID)).SingleOrDefault()
            ?? throw new Exception("GET ORDER-DETAIL BY ORDER-ID --> NULL");

        public OrderDetail GetOrderDetailByProductID(int ProductID)
            => OrderDetails.Where(od => od.OrderId.Equals(ProductID)).SingleOrDefault()
            ?? throw new Exception("GET ORDER-DETAIL BY PRODUCT-ID --> NULL");

        public void AddNew(OrderDetail orderDetail)
        {
            try
            {
                OrderDetail? mo = GetOrderDetailByOrderID(orderDetail.OrderId);
                if (mo == null || mo.ProductId != orderDetail.ProductId) OrderDetails.Add(orderDetail);
                else throw new Exception("Order Detail: product already exists! please update instead.");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                //CloseConnection();
                Console.WriteLine("DONE <-- ADD NEW ORDER-DETAIL");
            }
        }

        public void Update(OrderDetail orderDetail)
        {
            try
            {
                OrderDetail mo = GetOrderDetailByOrderID(orderDetail.OrderId);

                if (mo != null) OrderDetails.Update(mo);
                else throw new Exception("OrderDetail is already exists");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                //CloseConnection();
            }
        }

        public void Remove(int OrderID)
        {
            try
            {
                OrderDetail mo = GetOrderDetailByOrderID(OrderID);

                if (mo != null) OrderDetails.Remove(mo);
                else throw new Exception("OrderDetail does not already exists");
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally
            {
                //CloseConnection();
            }
        }
    }//end class
}//end namespace

