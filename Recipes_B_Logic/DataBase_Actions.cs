using Recipes_B_Logic.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_B_Logic
{
    public class DataBase_Actions
    {

        public void DataBase_Manager(Meal meal)
        {

            string? provider = ConfigurationManager.AppSettings["provider"];

            string? connectionString = ConfigurationManager.AppSettings["ConnectionString"];

            //try and catch here to find out why the following code is throughing the exception;

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            using (DbConnection? connection = factory.CreateConnection())
            {
                if (connection == null)
                {
                    //Console.WriteLine("Connection Error");
                    //Console.ReadLine();

                    Debug.Print("DB Connection null");
                    return;
                }

                connection.ConnectionString = connectionString;

                connection.Open();

                DbCommand? command = factory.CreateCommand();

                if (command == null)
                {
                    //Console.WriteLine("Command Error");
                    //Console.ReadLine();

                    Debug.Print("DB Command null");
                    return;
                }

                command.Connection = connection;

                command.CommandText = "Select * from ";



            }

        }
    }
}
