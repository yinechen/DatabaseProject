using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectModel.DbUser;
using ProjectModel.Instance;
using ProjectDAL;

namespace ProjectBLL
{
    public class BLLClass
    {
        public void CreateUser(DbInstance dbInstance, DbUser dbaUser, DbUser newUser)
        {
            DALClass myDal = new DALClass();
            myDal.CreateUser(dbInstance, dbaUser, newUser);
        }
    }
}
