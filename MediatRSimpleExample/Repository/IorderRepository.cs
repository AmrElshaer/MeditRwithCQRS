using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using MediatRSimpleExample.domainmodel;

namespace MediatRSimpleExample.Repository
{
   public interface IorderRepository
    {
       
        Task<IEnumerable<Order>> AllOrder();
        Task<Order> GetOrder(Guid Id);
        void CreateOrder(Order order);

    }
}
