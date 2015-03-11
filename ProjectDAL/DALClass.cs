using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectModel.DbUser;
using ProjectModel.Instance;
using ProjectCommon;

namespace ProjectDAL
{
    public class DALClass
    {
        public void CreateUser(DbInstance dbInstance, DbUser dbaUser, DbUser newUser)
        {
            string connInfo = dbInstance.ToDbInstanceString() + dbaUser.ToConnUserString();
            string strSql = newUser.ToCreateSqlString();
            DbHelper.ExecuteSql(connInfo, strSql);

            strSql = string.Format("GRANT UNLIMITED TABLESPACE TO \"{0}\"", newUser.UserName);
            DbHelper.ExecuteSql(connInfo, strSql);

            strSql = string.Format("GRANT \"CONNECT\" TO \"{0}\"",newUser.UserName);
            DbHelper.ExecuteSql(connInfo, strSql);

            strSql = string.Format("GRANT \"DBA\" TO \"{0}\"", newUser.UserName);
            DbHelper.ExecuteSql(connInfo, strSql);

            strSql = string.Format("GRANT \"RESOURCE\" TO \"{0}\"", newUser.UserName);
            DbHelper.ExecuteSql(connInfo, strSql);
        }
    }
}
