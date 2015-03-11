using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace ProjectCommon
{
    public class DbHelper
    {
        public static int ExecuteSql(string strConnInfo, string strSql)
        {
            try
            { 
                using(OleDbConnection conn = new OleDbConnection(strConnInfo))
                {
                    using (OleDbCommand cmd = new OleDbCommand(strSql, conn))
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                }
            }
            catch(OleDbException e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void ExecuteSqlTran(string strConnInfo, List<string> sqlList)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(strConnInfo))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        OleDbTransaction tx = conn.BeginTransaction();
                        cmd.Transaction = tx;
                        try
                        {
                            for (int i = 0; i < sqlList.Count; i++)
                            {
                                string strSql = sqlList[i];
                                if (!string.IsNullOrEmpty(strSql))
                                {
                                    cmd.CommandText = strSql;
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            tx.Commit();
                        }
                        catch
                        {
                            tx.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (OleDbException e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
