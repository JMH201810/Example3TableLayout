using SQLite;
namespace Example3TableLayout.Core.Repositories
{
    public interface IDBInterface
    {
        SQLiteConnection CreateConnection();
    }
}
