using MediatR;
using MediatRSimpleExample.domainmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRSimpleExample.Commands
{
    public class CreateOrder:IRequest< IEnumerable<Order>>
    {
        public Order _order;
        public CreateOrder(Order order)
        {
            _order = order;
        }
    }
}
