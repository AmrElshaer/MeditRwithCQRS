using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRSimpleExample.domainmodel;

namespace MediatRSimpleExample.Query
{
    public class GetAllOrders:IRequest<IEnumerable<Order>>
    {

    }
}
