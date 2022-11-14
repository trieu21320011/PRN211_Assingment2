using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository.Phong
{
    public class OrderDetailRepository:IOrderDetailRepository
    {
        private readonly Assignment2_PRN211Context _context;
        public OrderDetailRepository(Assignment2_PRN211Context context)
        {
            _context = context;
        }

        public void Add(OrderDetail orderDetail)
        {
            _context.Add(orderDetail);
        }

        public IEnumerable<OrderDetail> GetAllByOrderId(int orderId)
        {
            //Shouldn't select all columns in Product table since we only show Product Name
            return _context.OrderDetails.Where(x => x.OrderId == orderId)
                    .Include(x=> x.Product);
        }
    }
}
