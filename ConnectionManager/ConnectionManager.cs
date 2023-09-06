using Microsoft.SqlServer.Dts.Runtime;
using System.Data.SqlClient;

namespace ConnectionManagerNs
{
    [DtsConnection(ConnectionType = "SQLCS",
  DisplayName = "SqlConnectionManager (CS)",
  Description = "Connection manager for Sql Server")]
    public class ConnectionManager:ConnectionManagerBase
    {
        SqlConnection _connection;
        public override string ConnectionString { get;set; }

        public override object AcquireConnection(object txn)
        {
            

            _connection = new SqlConnection(ConnectionString);
            _connection.Open();
            return _connection;
        }

        public override DTSExecResult Validate(IDTSInfoEvents infoEvents)
        {
            if (string.IsNullOrEmpty(ConnectionString))
                return DTSExecResult.Failure;
            else
                return DTSExecResult.Success;
        }

        public override void ReleaseConnection(object connection)
        {
            _connection.Close();
            _connection.Dispose();
        }
    }
}
