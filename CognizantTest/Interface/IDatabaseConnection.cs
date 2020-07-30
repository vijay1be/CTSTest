using SQLite;

namespace CognizantTest.Interface
{
    public interface IDatabaseConnection
    {
        SQLiteConnection DbConnection();

        string GetDatabasePath();

    }
}
