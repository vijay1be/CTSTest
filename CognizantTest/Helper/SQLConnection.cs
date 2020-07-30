using System;
using System.Collections.Generic;
using CognizantTest.Interface;
using CognizantTest.Models;
using SQLite;
using Xamarin.Forms;

namespace CognizantTest.Helper
{
    public class SQLConnection
    {
        SQLiteConnection conn;
        public SQLConnection()
        {
            try
            { 
            IDatabaseConnection service = DependencyService.Get<IDatabaseConnection>();
            conn = DependencyService.Get<IDatabaseConnection>().DbConnection();
            }
            catch (Exception ex)
            {

            }

        }

        public void CreateTable()
        {
            try
            { 
            conn.CreateTable<Data>();
            }
            catch (Exception ex)
            {

            }
        }
        public int AddNewUser(Data user)
        {
            try
            { 
            int result = conn.Insert(user);
            return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public List<Data> GetAllUsers()
        {
            try
            { 
            List<Data> users = conn.Table<Data>().ToList();
            return users;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
