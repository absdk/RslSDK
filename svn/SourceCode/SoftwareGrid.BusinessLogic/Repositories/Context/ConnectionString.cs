
namespace SoftwareGrid.BusinessLogic.Repositories.Context
{
    public class ConnectionString : IConnectionString
    {
        public string DefaultConnectionString { get; private set; }

        public ConnectionString(string connectionString)
        {
            DefaultConnectionString = connectionString;
        }
    }
}