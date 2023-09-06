using Microsoft.SqlServer.Dts.Runtime;
using Npgsql;

namespace PostgreSQLConnectionManagerProject
{
    [DtsConnection(ConnectionType = "PostgreSQL", DisplayName = "PostgreSQL Connection Manager",
               Description = "Connection Manager for PostgreSQL")]
    public class PostgreSqlConnectionManager: ConnectionManagerBase 
    {
        NpgsqlConnection _connection;

        public override string ConnectionString { get; set; }

        public override DTSExecResult Validate(IDTSInfoEvents infoEvents)
        {
            if (ConnectionString == null)
                return DTSExecResult.Failure;
            else 
                return DTSExecResult.Success;
        }

        public override object AcquireConnection(object txn)
        {
            _connection = new NpgsqlConnection(ConnectionString);
            return _connection;
        }

        public override void ReleaseConnection(object connection)
        {
            _connection.Dispose();
        }


    }
}
