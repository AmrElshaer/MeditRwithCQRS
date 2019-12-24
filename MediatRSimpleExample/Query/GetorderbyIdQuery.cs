using MediatR;
using MediatRSimpleExample.domainmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRSimpleExample.Query
{
    public class GetorderbyIdQuery:IRequest<Order>
    {
        public Guid Id;
        public GetorderbyIdQuery(Guid guid)
        {
            this.Id = guid;
        }
    }
}
