using System;
using System.Linq;
using Raven.Abstractions.Indexing;
using Raven.Client.Indexes;

namespace RavenDB.AspNet.Identity
{
    //public class User_ByUserName<TUser> : AbstractGenericIndexCreationTask<TUser>
    //    where TUser : IdentityUser
    //{
    //    public User_ByUserName()
    //    {
    //        Map = users => from user in users
    //                          select new
    //                          {
    //                              user.UserName,
    //                              user.Id
    //                          };

    //        Store(x => x.UserName, FieldStorage.Yes);
    //        Index(x => x.UserName, FieldIndexing.Default);
    //        Index(x => x.Id, FieldIndexing.Default);
    //    }
    //}
}
