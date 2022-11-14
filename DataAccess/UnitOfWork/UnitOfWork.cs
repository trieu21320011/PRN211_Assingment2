using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess.Repository;
using DataAccess.Repository.Phong;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IProductForCartRepository _productForCartRepository;
        private readonly Assignment2_PRN211Context _context;
        public UnitOfWork()
        {
            _context = new Assignment2_PRN211Context();
            /*_orderRepository = new OrderRepository(_context);
            _orderDetailRepository = new  OrderDetailRepository(_context);   */
            _productForCartRepository = new ProductForCartRepository(_context);
        }
        public IOrderDetailRepository detailRepository => _orderDetailRepository;

        public IOrderRepository orderRepository => _orderRepository;

        public IProductForCartRepository productForCartRepository => _productForCartRepository;

        public void Save () 
        {
            try
            {
                _context.SaveChanges();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
