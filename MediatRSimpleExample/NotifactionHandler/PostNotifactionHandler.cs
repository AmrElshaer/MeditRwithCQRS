using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatRSimpleExample.DBAccess;
using MediatRSimpleExample.Notifaction;


namespace MediatRSimpleExample.NotifactionHandler
{
    public class PostNotifactionHandlerAddPost : INotificationHandler<PostNotifaction>
    {
        private readonly DBContext _db;

        public PostNotifactionHandlerAddPost(DBContext db )
        {
            this._db = db;
        }
        public async Task Handle(PostNotifaction notification, CancellationToken cancellationToken)
        {
            this._db.posts.Append(notification._post);
        }
    }
}
