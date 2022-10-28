using Recipes_B_Logic.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Recipes_B_Logic
{
    public class DataBase_Actions
    {

        
        string _sqlConnection = @"Data Source=(localdb)\ProjectModels;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public void StoreMeal(Meal meal)
        {

            using (SqlConnection conn = new SqlConnection(_sqlConnection))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "USE RecipesDataBase";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO MealTable(Id, Name, [Drink Alternate], Category, Area, Instructions, ThumbNail, Youtube, Ingred1, Ingred2, Ingred3, Ingred4, Ingred5, Ingred6, Ingred7, Ingred8, Ingred9, Ingred10, Ingred11, Ingred12 ,Ingred13, Ingred14, Ingred15, Ingred16, Ingred17, Ingred18, Ingred19, Ingred20, Measure1, Measure2, Measure3, Measure4, Measure5, Measure6, Measure7, Measure8, Measure9, Measure10, Measure11, Measure12, Measure13, Measure14, Measure15, Measure16, Measure17, Measure18, Measure19, Measure20, Source, ImageSource, CreativeCommonsConfirmed, dateModified) Value(@Id, @Name, @[Drink Alternate], @Category, @Area, @Instructions, @ThumbNail, @Youtube, @Ingred1, @Ingred2, @Ingred3, @Ingred4, @Ingred5, @Ingred6, @Ingred7, @Ingred8, @Ingred9, @Ingred10, @Ingred11, @Ingred12, @Ingred13, @Ingred14, @Ingred15, @Ingred16, @Ingred17, @Ingred18, @Ingred19, @Ingred20, @Measure1, @Measure2, @Measure3, @Measure4, @Measure5, @Measure6, @Measure7, @Measure8, @Measure9, @Measure10, @Measure11, @Measure12, @Measure13, @Measure14, @Measure15, @Measure16, @Measure17, @Measure18, @Measure19, @Measure20, @Source, @ImageSource, @CreativeCommonsConfirmed, @dateModified)";


                    /*
                     * Add a Parameter with code in this comment.
                     * cmd.Parameters.Add("@id", SqlDbType.Int).Value ) = id;
                     *  cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 40).Value ) = Artist
                     */
                    cmd.ExecuteNonQuery();

                }

                conn.Close();
            }
        }

        public void DatabaseConnectionTest()
        {
            string databaseName = "";

            using (SqlConnection conn = new SqlConnection(_sqlConnection))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "USE RecipesDataBase";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT Name FROM MealTable WHERE Id = 0";


                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        databaseName = dr[0].ToString();
                        try { Debug.Print(databaseName); }
                        catch (Exception ex)
                        {
                            Debug.Print(ex.Message.ToString());
                        }

                    }
                }

                conn.Close();
            }
        }

    }
}



        //public void DataBase_Manager(Meal meal)
        //{

        //    string? provider = ConfigurationManager.AppSettings["provider"];

        //    string? connectionString = ConfigurationManager.AppSettings["ConnectionString"];
           

        //    //try and catch here to find out why the following code is throughing the exception;

        //      DbProviderFactory factory = DbProviderFactories.GetFactory(provider);


        //        using (DbConnection? connection = factory.CreateConnection())
        //        {
        //            if (connection == null)
        //            {
        //                //Console.WriteLine("Connection Error");
        //                //Console.ReadLine();

        //                Debug.Print("DB Connection null");
        //                return;
        //            }

        //            connection.ConnectionString = connectionString;

        //            connection.Open();

        //            DbCommand? command = factory.CreateCommand();

        //            if (command == null)
        //            {
        //                //Console.WriteLine("Command Error");
        //                //Console.ReadLine();

        //                Debug.Print("DB Command null");
        //                return;
        //            }

        //            command.Connection = connection;

        //            command.CommandText = "Select * from ";
        //        }
        //    }
        //}

    
    

