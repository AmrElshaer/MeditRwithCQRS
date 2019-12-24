using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRSimpleExample.domainmodel;

namespace MediatRSimpleExample.Notifaction
{
    public class PostNotifaction: INotification
    {
        public  Post _post;

        
    }
}
