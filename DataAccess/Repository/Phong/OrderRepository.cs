using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Phong
{ 
    public class OrderRepository : IOrderRepository
    {
        private readonly Assignment2_PRN211Context _context;
        public OrderRepository(Assignment2_PRN211Context context)
        {
            _context = context;
        }
        public void Add(Order order)
        {
            _context.Add(order);
        }

        public void Delete(Order order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            try
            {
                var a = _context.Orders;
                return a.ToList();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public IEnumerable<Order> GetAllByMemberId(int memberId)
        {
            throw new NotImplementedException();
        }

        public void Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
