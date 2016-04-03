using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using WLXK.SmartFish.IDal;

namespace WLXK.SmartFish.DalFactory
{
    public static class DbSessionFactory
    {
        public static IDbSession GetCurrentDbSession()
        {
            IDbSession db = (IDbSession)CallContext.GetData("DbSession");

            if (db == null)
            {
                db = new DbSession();
                CallContext.SetData("DbSession", db);
            }
            return db;
        }
    }
}
