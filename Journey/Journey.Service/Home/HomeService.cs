using Entities.Model;
using Journey.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tc.Gny.Framework.ORM.Core;

namespace Journey.Service.Home
{
    public class HomeService
    {
        public string getOrder()
        {
            using (var context = new DbContext<TestTable>(DBOperationType.Read, DbName.Journey))
            {
                return context.GetContext<TestTable>().Query("", "", null).FirstOrDefault().FullName.ToString();
            }
        }
    }
}
