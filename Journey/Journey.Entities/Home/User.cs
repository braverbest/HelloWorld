using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tc.Gny.Framework.ORM.Attrbuites;
using Tc.Gny.Framework.ORM.Base;

namespace Journey.Entities.Home
{
    [Serializable]
    [Entity("User")]
    public partial class User : BaseEntity<User>
    {
        private int _id;

        /// <summary>
        /// Id，自增长
        /// </summary>
        [PrimaryKey]
        [Identity]
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this.ChangeStack("Id", value, this._id);
                this._id = value;
            }
        }

        private string _userName;

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get
            {
                return this._userName;
            }
            set
            {
                this.ChangeStack("UserName", value, this._userName);
                this._userName = value;
            }
        }

        private string _password;

        /// <summary>
        /// 用户名
        /// </summary>
        public string Password
        {
            get
            {
                return this._password;
            }
            set
            {
                this.ChangeStack("Password", value, this._password);
                this._password = value;
            }
        }
    }
}
