using System;
using System.IO;
using CognizantTest.Android.Helpers;
using CognizantTest.Interface;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseConnection))]
namespace CognizantTest.Android.Helpers
{
    public class DatabaseConnection : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "MyMx.db3";
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), dbName);
            return new SQLiteConnection(path);
        }

        public string GetDatabasePath()
        {
            var dbName = "MyMx.db3";
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), dbName);
            return path;
        }
    }
}