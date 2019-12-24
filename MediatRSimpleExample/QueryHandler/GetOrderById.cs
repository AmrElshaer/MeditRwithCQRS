using MediatR;
using MediatRSimpleExample.domainmodel;
using MediatRSimpleExample.Query;
using MediatRSimpleExample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRSimpleExample.QueryHandler
{
    public class GetOrderById : IRequestHandler<GetorderbyIdQuery, Order>
    {
        public IorderRepository _orderrepository;
        public GetOrderById(IorderRepository orderrepository)
        {
            this._orderrepository = orderrepository;
        }
      

        public async Task<Order> Handle(GetorderbyIdQuery request, CancellationToken cancellationToken)
        {
            var resuilt= await _orderrepository.GetOrder(request.Id);
            if (resuilt!=null)
            {
                return resuilt;
            }
            return null;
        }
    }
}
