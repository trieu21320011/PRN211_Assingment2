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
        //{
        //    var orderDetails = new List<OrderDetail>();

        //    try
        //    {
        //        foreach (var x in OrderDetails)
        //        {
        //            orderDetails.Add(new OrderDetail
        //            {
        //                OrderId = x.OrderId,
        //                ProductId = x.ProductId,
        //                UnitPrice = x.UnitPrice,
        //                Quantity = x.Quantity,
        //                Discount = x.Discount
        //            });
        //        }
        //    }
        //    catch (Exception ex) { throw new Exception(ex.Message); }
        //    finally { Console.WriteLine("\t\t\tOKE DONE GET_ORDER-DETAIL-LIST"); }

        //    return orderDetails;
        //}

        public OrderDetail GetOrderDetailByOrderID(int OrderID)
            => OrderDetails.Where(od => od.OrderId.Equals(OrderID)).SingleOrDefault()
            ?? throw new Exception("GET ORDER-DETAIL BY ORDER-ID --> NULL");
        //{
        //    OrderDetail? orderDetail;

        //    try { orderDetail = OrderDetails.Where(od => od.OrderId.Equals(OrderID)).SingleOrDefault(); }
        //    catch (Exception ex) { throw new Exception(ex.Message); }
        //    finally
        //    { Console.WriteLine("\t\t\tOKE DONE GET_ORDER-DETAIL BY ORDER-ID"); }

        //    return orderDetail;
        //}

        public OrderDetail GetOrderDetailByProductID(int ProductID)
            => OrderDetails.Where(od => od.OrderId.Equals(ProductID)).SingleOrDefault()
            ?? throw new Exception("GET ORDER-DETAIL BY PRODUCT-ID --> NULL");
        //{
        //    OrderDetail? orderDetail;

        //    try { orderDetail = OrderDetails.Where(od => od.OrderId.Equals(ProductID)).SingleOrDefault(); }
        //    catch (Exception ex) { throw new Exception(ex.Message); }
        //    finally
        //    { Console.WriteLine("\t\t\tOKE DONE GET_ORDER-DETAIL BY PRODUCT-ID"); }

        //    return orderDetail;
        //}

        public void AddNew(OrderDetail orderDetail)
        {
            try
            {
                OrderDetail? mo = GetOrderDetailByOrderID(orderDetail.OrderId);
                if (mo == null || mo.ProductId != orderDetail.ProductId)
                {
                    //string SQLInsert = "Insert OrderDetail values(@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount)";
                    //var parameters = new List<SqlParameter>();
                    //parameters.Add(dataProvider.CreateParameter("@OrderID", 4, orderDetail.OrderID, DbType.Int32));
                    //parameters.Add(dataProvider.CreateParameter("@UnitPrice", 17, orderDetail.UnitPrice, DbType.Decimal));
                    //parameters.Add(dataProvider.CreateParameter("@ProductID", 4, orderDetail.ProductID, DbType.Int32));
                    //parameters.Add(dataProvider.CreateParameter("@Quantity", 4, orderDetail.Quantity, DbType.Int32));
                    //parameters.Add(dataProvider.CreateParameter("@Discount", 8, orderDetail.Discount, DbType.Double));
                    //dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                    OrderDetails.Add(orderDetail);
                }
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

                if (mo != null)
                {
                    //string SQLUpdate = "Update OrderDetail set ProductID = @ProductID,UnitPrice = @UnitPrice , Quantity = @Quantity,Discount= @Discount where OrderID = @OrderID)";
                    //var parameters = new List<SqlParameter>();
                    //parameters.Add(dataProvider.CreateParameter("@OrderID", 4, orderDetail.OrderID, DbType.Int32));
                    //parameters.Add(dataProvider.CreateParameter("@UnitPrice", 17, orderDetail.UnitPrice, DbType.Decimal));
                    //parameters.Add(dataProvider.CreateParameter("@ProductID", 4, orderDetail.ProductID, DbType.Int32));
                    //parameters.Add(dataProvider.CreateParameter("@Quantity", 4, orderDetail.Quantity, DbType.Int32));
                    //parameters.Add(dataProvider.CreateParameter("@Discount", 8, orderDetail.Discount, DbType.Double));
                    //dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                    OrderDetails.Update(mo);
                    //.Where(od => od.OrderId.Equals(mo.OrderId));
                }
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

                if (mo != null)
                {
                    //string SQLDelete = "Delete OrderDetail where OrderID = @OrderID)";
                    //var param = dataProvider.CreateParameter("@OrderID", 4, OrderID, DbType.Int32);
                    //dataProvider.Delete(SQLDelete, CommandType.Text, param);
                    OrderDetails.Remove(mo);
                }
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

