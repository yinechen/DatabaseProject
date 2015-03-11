using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectModel.DbUser
{
    public class DbUser
    {
        private string _userName = "xm";

        private string _userPwd = "xm";

        public string UserName
        {
            get
            { return _userName; }
            set
            { this._userName = value; }
        }
        public string UserPwd
        {
            get { return _userPwd; }
            set { this._userPwd = value; }
        }

        public virtual string ToCreateSqlString()
        {
            return string.Format("CREATE USER \"{0}\" PROFILE \"DEFAULT\" IDENTIFIED BY \"{1}\" DEFAULT TABLESPACE \"TRANSITDB\" TEMPORARY TABLESPACE \"TEMP\" ACCOUNT UNLOCK", _userName, _userPwd);
            //return string.Format("CREATE USER \"{0}\" PROFILE \"DEFAULT\" IDENTIFIED BY \"{1}\" DEFAULT TABLESPACE \"TRANSITDB\" TEMPORARY TABLESPACE \"TEMP\" ACCOUNT UNLOCK GRANT UNLIMITED TABLESPACE TO \"{2}\" GRANT \"CONNECT\" TO \"{3}\" GRANT \"DBA\" TO \"{4}\" GRANT \"RESOURCE\" TO \"{5}\"", _userName, _userPwd, _userName, _userName, _userName, _userName);
        }

        public virtual string ToConnUserString()
        {
            return string.Format("User Id={0};Password={1};", "system", "gvitech");
        }
    }
}
