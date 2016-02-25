using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tc.Gny.Framework.ORM.Attrbuites;
using Tc.Gny.Framework.ORM.Base;

namespace Entities.Model
{
    [Serializable]
    [Entity("TestTable")]
    public partial class TestTable : BaseEntity<TestTable>
    {
        public int TestId { get; set; }
        public int Code { get; set; }
        public string FullName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUserName { get; set; }
        public string Remark { get; set; }
    }
}
