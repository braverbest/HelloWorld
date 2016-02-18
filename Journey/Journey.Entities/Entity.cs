using Tc.Gny.Framework.ORM.Base;
using Tc.Gny.Framework.ORM.Core;
using Tc.Gny.Framework.ORM.Implementation;
using Tc.Gny.Framework.ORM.Interface;

namespace Journey.Entities.Entity
{
    public class DbContext<T> : DBContextBase
        where T : BaseEntity<T>, new()
    {
        public DbContext(DBOperationType type, string name)
            : base(type, name)
        {

        }

        public IDBContext<T> Context
        {
            get
            {
                return new EntityContext<T>(Session);
            }
        }
    }

    public partial class DbContext : DBContextBase
    {
        public DbContext(DBOperationType type, string name)
            : base(type, name)
        {

        }
    }
}