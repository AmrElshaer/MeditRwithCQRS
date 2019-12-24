using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatRSimpleExample.DBAccess;
using MediatRSimpleExample.domainmodel;

namespace MediatRSimpleExample.Repository
{
    public class OrderRepository : IorderRepository

    {
        public DBContext DbOrder;
        public OrderRepository(DBContext dbcontext)
        {
            DbOrder = dbcontext;
        }

        public async Task<IEnumerable<Order>> AllOrder()
        {
            return DbOrder.Orders;
        }

        public void CreateOrder(Order order)
        {
            this.DbOrder.Orders.Append(order);
        }

        public async Task<Order> GetOrder(Guid Id)
        {
            var order = this.DbOrder.Orders.FirstOrDefault(a=>a.Id==Id);
            if (order ==null)
            {
                return null;
            }
            return order;
        }
    }
}
