using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectModel.Instance
{
    public class DbInstance
    {
        private string _serverIp = "localhost";//"192.168.7.138";
        private uint _port = 1521;
        private string _instanceName = "orcl";

        public virtual string ToDbInstanceString()
        {
            return string.Format("Provider=OraOLEDB.Oracle;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1})))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={2})));", _serverIp,_port,_instanceName);
        }
    }
}
