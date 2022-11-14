using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
namespace DataAccess.Repository.Phong
{ 
    public interface IOrderDetailRepository
    {
        void Add(OrderDetail orderDetail);
        IEnumerable<OrderDetail> GetAllByOrderId(int orderId);

    }
}
