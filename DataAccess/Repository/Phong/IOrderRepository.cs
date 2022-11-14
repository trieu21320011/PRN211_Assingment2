using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
namespace DataAccess.Repository.Phong
{ 
    public interface IOrderRepository
    {
        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);   
        IEnumerable<Order> GetAll();
        IEnumerable<Order> GetAllByMemberId(int memberId);
    }
}
