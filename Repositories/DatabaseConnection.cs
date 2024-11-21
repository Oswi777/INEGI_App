using MySql.Data.MySqlClient;

public class DatabaseConnection
{
    private static DatabaseConnection _instance;
    private readonly string connectionString = "Server=localhost;Database=censoinegi;User ID=root;Password=;Pooling=true;";

    // Constructor privado para evitar instanciación externa
    private DatabaseConnection() { }

    // Método para obtener la instancia única (Singleton)
    public static DatabaseConnection GetInstance()
    {
        if (_instance == null)
        {
            _instance = new DatabaseConnection();
        }
        return _instance;
    }

    // Método para obtener una nueva conexión cada vez que se necesite
    public MySqlConnection GetConnection()
    {
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();
        return connection;
    }
}
