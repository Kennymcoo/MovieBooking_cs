namespace DataAccess;

internal class DataAccessManager
{
    private readonly string _connectionString = "Server=DESKTOP-GRK5D76\\SQLEXPRESS01;Database=movieTheater;Trusted_Connection=true";

    public SqlConnection Connection { get; }

    public DataAccessManager()
	{
        Connection = new SqlConnection(_connectionString);
        Connection.Open();
    }
}
