using MediatR;
using MediatRSimpleExample.Commands;
using MediatRSimpleExample.domainmodel;
using MediatRSimpleExample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRSimpleExample.CommandHandler
{
    public class CreateOrderHandler : IRequestHandler<CreateOrder, IEnumerable<Order>>
    {

        IorderRepository iorderRepository;
        public CreateOrderHandler( IorderRepository orderrepository)
        {
            this.iorderRepository = orderrepository;
        }
        public Task<IEnumerable<Order>> Handle(CreateOrder request, CancellationToken cancellationToken)
        {
            this.iorderRepository.CreateOrder(request._order);
            return this.iorderRepository.AllOrder();
        }
    }
}
