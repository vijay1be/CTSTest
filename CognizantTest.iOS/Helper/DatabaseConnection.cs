using CognizantTest.Interface;
using CognizantTest.iOS.Helpers;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseConnection))]
namespace CognizantTest.iOS.Helpers
{
    public class DatabaseConnection : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "MyMx.db3";
            string personalFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder = Path.Combine(personalFolder, "..", "Library","Databases");
            if (!Directory.Exists(libraryFolder))
                Directory.CreateDirectory(libraryFolder);
            var path = Path.Combine(libraryFolder, dbName);
            return new SQLiteConnection(path);
        }

        public string GetDatabasePath()
        {
            var dbName = "MyMx.db3";
            string personalFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder = Path.Combine(personalFolder, "..", "Library", "Databases");
            if (!Directory.Exists(libraryFolder))
                Directory.CreateDirectory(libraryFolder);
            var path = Path.Combine(libraryFolder, dbName);
            return path;
        }
    }
}