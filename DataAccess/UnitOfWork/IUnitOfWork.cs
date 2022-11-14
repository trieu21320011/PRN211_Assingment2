using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repository;
namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        IOrderDetailRepository detailRepository { get; }
        IOrderRepository orderRepository { get; }
        IProductForCartRepository productForCartRepository { get; }
        void Save();
    }
}
