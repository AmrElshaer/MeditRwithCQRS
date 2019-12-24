using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatRSimpleExample.domainmodel;
using MediatRSimpleExample.Query;
using MediatRSimpleExample.Repository;

namespace MediatRSimpleExample.QueryHandler
{
    public class GetAllOrderHandler : IRequestHandler<GetAllOrders, IEnumerable<Order>>
    {
        public IorderRepository orderrepository;
        public GetAllOrderHandler(IorderRepository _IorderRepository)
        {
            orderrepository = _IorderRepository;
        }
        public async Task<IEnumerable<Order>> Handle(GetAllOrders request, CancellationToken cancellationToken)
        {
          var response=await orderrepository.AllOrder();
            if (response==null)
            {
                return null;
            }
            return response;
        }
    }
}
