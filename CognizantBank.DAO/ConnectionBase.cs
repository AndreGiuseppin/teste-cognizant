using System;
using System.Data.SqlClient;

namespace CognizantBank.DAO
{
    public class ConnectionBase
    {
        protected SqlDataReader myReader;
        protected SqlCommand myCommand;
        protected SqlConnection MainConn = new SqlConnection("Data Source=ANDREGIUSEPPIN\\SQLANDRE18;Initial Catalog=CognizantBank;Integrated Security=true");        
    }
}