using System.Collections.Generic;
using SQLite;
using Example3TableLayout.Core.Repositories;
using MvvmCross.Platform;
using Example3TableLayout.Core.Models;


namespace Example3TableLayout.Core.Services
{
    public class DatabaseManager
    {
        SQLiteConnection dbConnection;

        public DatabaseManager()
        {
            dbConnection = Mvx.Resolve<IDBInterface>().CreateConnection();
        }

        public List<Categories> GetCategories()
        {
            return dbConnection.Query<Categories>("select * from [Categories]");
        }

        public int SaveCategory (Categories aCategory)
        {
            return dbConnection.Insert(aCategory);
        }
    }
}
