using MediatRSimpleExample.domainmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRSimpleExample.DBAccess
{
    public class DBContext
    {
        //You Can Add Your DataBase conntection Instead of These
        public IEnumerable<Order> Orders = new List<Order>();
        public IEnumerable<Post> posts = new List<Post>();
    }
}
