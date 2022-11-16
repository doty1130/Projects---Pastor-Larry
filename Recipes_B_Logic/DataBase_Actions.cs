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

        //OLD Database FUNCTIONs Totally defunct

   //     /*
   //     Connection String for database
   //     */
   //     string _sqlConnection = @"Data Source=(localdb)\ProjectModels;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

   //     /*
   //      Uploads meal data from api into the database.
   //     */
   //     public void StoreMeal(Meal meal)
   //     {
           
   //             using (SqlConnection conn = new SqlConnection(_sqlConnection))
   //             {
   //                 conn.Open();


   //                 try
   //                 {
   //                     using (SqlCommand cmd = new SqlCommand())
   //                     {
   //                         cmd.Connection = conn;

   //                         cmd.CommandText = "RecipesDataBase.dbo.StoreMeal";

   //                         cmd.CommandType = CommandType.StoredProcedure;

   //                         cmd.Parameters.Add(new SqlParameter("@MealId", Convert.ToInt64(meal.idMeal)));

   //                         cmd.Parameters.Add(new SqlParameter("@MName", meal.strMeal));

   //                         cmd.Parameters.Add(new SqlParameter("@DrinkAlternate", meal.strDrinkAlternate));

   //                         cmd.Parameters.Add(new SqlParameter("@Category", meal.strCategory));

   //                         cmd.Parameters.Add(new SqlParameter("@Area", meal.strArea));

   //                         cmd.Parameters.Add(new SqlParameter("@Instructions", meal.strInstructions));

   //                         cmd.Parameters.Add(new SqlParameter("@ThumbNail", meal.strMealThumb));

   //                         cmd.Parameters.Add(new SqlParameter("@Youtube", meal.strYoutube));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred1", meal.strIngredient1));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred2", meal.strIngredient2));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred3", meal.strIngredient3));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred4", meal.strIngredient4));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred5", meal.strIngredient5));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred6", meal.strIngredient6));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred7", meal.strIngredient7));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred8", meal.strIngredient8));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred9", meal.strIngredient9));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred10", meal.strIngredient10));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred11", meal.strIngredient11));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred12", meal.strIngredient12));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred13", meal.strIngredient13));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred14", meal.strIngredient14));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred15", meal.strIngredient15));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred16", meal.strIngredient16));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred17", meal.strIngredient17));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred18", meal.strIngredient18));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred19", meal.strIngredient19));

   //                         cmd.Parameters.Add(new SqlParameter("@Ingred20", meal.strIngredient20));

   //                         cmd.Parameters.Add(new SqlParameter("@Measure1", meal.strMeasure1));

   //                         cmd.Parameters.Add(new SqlParameter("@Measure2", meal.strMeasure2));

   //                         cmd.Parameters.Add(new SqlParameter("@Measure3", meal.strMeasure3));

   //                         cmd.Parameters.Add(new SqlParameter("@Measure4", meal.strMeasure4));
                         
   //                         cmd.Parameters.Add(new SqlParameter("@Measure5", meal.strMeasure5));
                       
   //                         cmd.Parameters.Add(new SqlParameter("@Measure6", meal.strMeasure6));
                        
   //                         cmd.Parameters.Add(new SqlParameter("@Measure7", meal.strMeasure7));
                         
   //                         cmd.Parameters.Add(new SqlParameter("@Measure8", meal.strMeasure8));

   //                         cmd.Parameters.Add(new SqlParameter("@Measure9", meal.strMeasure9));

   //                         cmd.Parameters.Add(new SqlParameter("@Measure10", meal.strMeasure10));
                          
   //                         cmd.Parameters.Add(new SqlParameter("@Measure11", meal.strMeasure11));
                          
   //                         cmd.Parameters.Add(new SqlParameter("@Measure12", meal.strMeasure12));
                          
   //                         cmd.Parameters.Add(new SqlParameter("@Measure13", meal.strMeasure13));
                           
   //                         cmd.Parameters.Add(new SqlParameter("@Measure14", meal.strMeasure14));
                         
   //                         cmd.Parameters.Add(new SqlParameter("@Measure15", meal.strMeasure15)); 

   //                         cmd.Parameters.Add(new SqlParameter("@Measure16", meal.strMeasure16));

   //                         cmd.Parameters.Add(new SqlParameter("@Measure17", meal.strMeasure17));

   //                         cmd.Parameters.Add(new SqlParameter("@Measure18", meal.strMeasure18));
                          
   //                         cmd.Parameters.Add(new SqlParameter("@Measure19", meal.strMeasure19));
                            
   //                         cmd.Parameters.Add(new SqlParameter("@Measure20", meal.strMeasure20));
                            
   //                         cmd.Parameters.Add(new SqlParameter("@MSource", meal.strSource));

   //                         cmd.Parameters.Add(new SqlParameter("@ImageSource", meal.strImageSource));

   //                         cmd.Parameters.Add(new SqlParameter("@CreativeCommonsConfirmed", meal.strCreativeCommonsConfirmed));
                        

                           

   //                         cmd.ExecuteNonQuery();
   //                         Debug.Print("Uploaded Meal");
   //                     }
   //                 }
   //                 catch (Exception ex)
   //                 { Debug.Print(ex.Message.ToString()); }

   //                 conn.Close();
   //             }
            
            
   //     }

   //     /*
   //    Test database connection. Example code. Will remove 
   //     */
   //     public void DatabaseConnectionTest()
   //     {
   //         string databaseName = "";

   //         using (SqlConnection conn = new SqlConnection(_sqlConnection))
   //         {
   //             conn.Open();

   //             using (SqlCommand cmd = new SqlCommand())
   //             {
   //                 cmd.Connection = conn;
   //                 cmd.CommandText = "USE RecipesDataBase";
   //                 cmd.ExecuteNonQuery();

   //                 cmd.CommandText = "SELECT Name FROM MealTable WHERE Id = 0";


   //                 SqlDataReader dr = cmd.ExecuteReader();

   //                 while (dr.Read())
   //                 {
   //                     databaseName = dr[0].ToString();
   //                     try { Debug.Print(databaseName); }
   //                     catch (Exception ex)
   //                     {
   //                         Debug.Print(ex.Message.ToString());
   //                     }

   //                 }
   //             }

   //             conn.Close();
   //         }
   //     }

   //     /*
   //         returns a list of meal categories. 
   //         Sorts categories, removes duplicates and nulls. returns unique values
   //         uses dynamic sql to get the right column data. 
   //         Goal: will convert sorting algorithm to sql variation
   //     */
   //     public List<string> GetCatagory()
   //     { 
   //         List<string> CategoryList = new List<string>();

   //             using (SqlConnection conn = new SqlConnection(_sqlConnection))
   //             {
   //                 conn.Open();

   //                 using (SqlCommand cmd = new SqlCommand())
   //                 {
   //                 cmd.Connection = conn;

   //                 cmd.CommandText = "RecipesDataBase.dbo.ReturnColumn";

   //                 cmd.Parameters.Add(new SqlParameter("@Column", "Category"));
   //                 cmd.Parameters.Add(new SqlParameter("@Table", "MealTable"));

   //                 cmd.CommandType = CommandType.StoredProcedure;

   //                 SqlDataReader dr = cmd.ExecuteReader();
   //                     while (dr.Read())
   //                     {
   //                        CategoryList.Add(dr[0].ToString());
   //                     }
   //                 }

   //                 conn.Close();
   //             }


   //         /*
			//Algorithm used to clean data. 
   //         returns no nulls, returns only one instance of each category
		 //   */
   //         CategoryList.Sort();
   //         if (CategoryList.Contains("null"))
   //             CategoryList.Remove("null");

   //         List<string> returnList = new List<string>();

   //         foreach (string category in CategoryList)
   //              {
   //             if (!returnList.Contains(category))
   //             {
   //                 returnList.Add(category);
   //             }
   //             else
   //                 continue;
   //              }    

   //             return returnList;
   //     }

   //     /*
   //        returns a list of meals by Selected category. 
   //    */
   //     public List<Meal> GetMealsByCat(string cat)
   //     { 
   //         List<Meal> meals = new List<Meal>();

   //         using (SqlConnection conn = new SqlConnection(_sqlConnection))
   //         {
   //             conn.Open();

   //             using (SqlCommand cmd = new SqlCommand())
   //             {
   //                 cmd.Connection = conn;

   //                 cmd.CommandText = "RecipesDataBase.dbo.ReturnMealsByCat";

   //                 cmd.Parameters.Add(new SqlParameter("@Cat", cat));

   //                 cmd.CommandType = CommandType.StoredProcedure;


   //                 SqlDataReader dr = cmd.ExecuteReader();
   //                 while (dr.Read())
   //                 {
   //                    Meal meal = new Meal();
   //                     meal.idMeal = dr[1].ToString();
   //                     meal.strMeal = dr[2].ToString();
   //                     meal.strDrinkAlternate = dr[3].ToString();
   //                     meal.strCategory = dr[4].ToString();
   //                     meal.strArea = dr[5].ToString();
   //                     meal.strInstructions = dr[6].ToString();
   //                     meal.strMealThumb = dr[7].ToString();
   //                     meal.strYoutube = dr[8].ToString();
   //                     meal.strIngredient1 = dr[9].ToString();
   //                     meal.strIngredient2 = dr[10].ToString();
   //                     meal.strIngredient3 = dr[11].ToString();
   //                     meal.strIngredient4 = dr[12].ToString();
   //                     meal.strIngredient5 = dr[13].ToString();
   //                     meal.strIngredient6 = dr[14].ToString();
   //                     meal.strIngredient7 = dr[15].ToString();
   //                     meal.strIngredient8 = dr[16].ToString();
   //                     meal.strIngredient9 = dr[17].ToString();
   //                     meal.strIngredient10 = dr[18].ToString();
   //                     meal.strIngredient11 = dr[19].ToString();
   //                     meal.strIngredient12 = dr[20].ToString();
   //                     meal.strIngredient13 = dr[21].ToString();
   //                     meal.strIngredient14 = dr[22].ToString();

   //                     meal.strIngredient15 = dr[23].ToString();
   //                     meal.strIngredient16 = dr[24].ToString();
   //                     meal.strIngredient17 = dr[25].ToString();
   //                     meal.strIngredient18 = dr[26].ToString();
   //                     meal.strIngredient19 = dr[27].ToString();
   //                     meal.strIngredient20 = dr[28].ToString();
   //                     meal.strMeasure1 = dr[29].ToString();
   //                     meal.strMeasure2 = dr[30].ToString();
   //                     meal.strMeasure3 = dr[31].ToString();
   //                     meal.strMeasure4 = dr[32].ToString();

   //                     meal.strMeasure5 = dr[33].ToString();
   //                     meal.strMeasure6 = dr[34].ToString();
   //                     meal.strMeasure7 = dr[35].ToString();
   //                     meal.strMeasure8 = dr[36].ToString();
   //                     meal.strMeasure9 = dr[37].ToString();
   //                     meal.strMeasure10 = dr[38].ToString();
   //                     meal.strMeasure11 = dr[39].ToString();
   //                     meal.strMeasure12 = dr[40].ToString();
   //                     meal.strMeasure13 = dr[41].ToString();
   //                     meal.strMeasure14 = dr[42].ToString();
   //                     meal.strMeasure15 = dr[43].ToString();
   //                     meal.strMeasure16 = dr[44].ToString();
   //                     meal.strMeasure17 = dr[45].ToString();
   //                     meal.strMeasure18 = dr[46].ToString();
   //                     meal.strMeasure19 = dr[47].ToString();
   //                     meal.strMeasure20 = dr[48].ToString();
   //                     meal.strSource = dr[49].ToString();
   //                     meal.strImageSource = dr[50].ToString();
   //                     meal.strCreativeCommonsConfirmed = dr[51].ToString();
   //                     meal.dateModified = dr[52].ToString();

   //                     meals.Add(meal);
   //                 }
   //             }

   //             conn.Close();
   //         }

   //         return meals;
   //     }


   //     /*
   //       returns a meal by Selected Id. 
   //   */

   //     public Meal GetMealByID(int ID)
   //     {
            
   //         Meal meal = new Meal();
   //         using (SqlConnection conn = new SqlConnection(_sqlConnection))
   //         {
   //             conn.Open();

   //             using (SqlCommand cmd = new SqlCommand())
   //             {
   //                 cmd.Connection = conn;

   //                 cmd.CommandText = "RecipesDataBase.dbo.ReturnMealByID";

   //                 cmd.Parameters.Add(new SqlParameter("@ID", ID));

   //                 cmd.CommandType = CommandType.StoredProcedure;


   //                 SqlDataReader dr = cmd.ExecuteReader();
   //                 while (dr.Read())
   //                 {
                       
   //                     meal.idMeal = dr[1].ToString();
   //                     meal.strMeal = dr[2].ToString();
   //                     meal.strDrinkAlternate = dr[3].ToString();
   //                     meal.strCategory = dr[4].ToString();
   //                     meal.strArea = dr[5].ToString();
   //                     meal.strInstructions = dr[6].ToString();
   //                     meal.strMealThumb = dr[7].ToString();
   //                     meal.strYoutube = dr[8].ToString();
   //                     meal.strIngredient1 = dr[9].ToString();
   //                     meal.strIngredient2 = dr[10].ToString();
   //                     meal.strIngredient3 = dr[11].ToString();
   //                     meal.strIngredient4 = dr[12].ToString();
   //                     meal.strIngredient5 = dr[13].ToString();
   //                     meal.strIngredient6 = dr[14].ToString();
   //                     meal.strIngredient7 = dr[15].ToString();
   //                     meal.strIngredient8 = dr[16].ToString();
   //                     meal.strIngredient9 = dr[17].ToString();
   //                     meal.strIngredient10 = dr[18].ToString();
   //                     meal.strIngredient11 = dr[19].ToString();
   //                     meal.strIngredient12 = dr[20].ToString();
   //                     meal.strIngredient13 = dr[21].ToString();
   //                     meal.strIngredient14 = dr[22].ToString();

   //                     meal.strIngredient15 = dr[23].ToString();
   //                     meal.strIngredient16 = dr[24].ToString();
   //                     meal.strIngredient17 = dr[25].ToString();
   //                     meal.strIngredient18 = dr[26].ToString();
   //                     meal.strIngredient19 = dr[27].ToString();
   //                     meal.strIngredient20 = dr[28].ToString();
   //                     meal.strMeasure1 = dr[29].ToString();
   //                     meal.strMeasure2 = dr[30].ToString();
   //                     meal.strMeasure3 = dr[31].ToString();
   //                     meal.strMeasure4 = dr[32].ToString();

   //                     meal.strMeasure5 = dr[33].ToString();
   //                     meal.strMeasure6 = dr[34].ToString();
   //                     meal.strMeasure7 = dr[35].ToString();
   //                     meal.strMeasure8 = dr[36].ToString();
   //                     meal.strMeasure9 = dr[37].ToString();
   //                     meal.strMeasure10 = dr[38].ToString();
   //                     meal.strMeasure11 = dr[39].ToString();
   //                     meal.strMeasure12 = dr[40].ToString();
   //                     meal.strMeasure13 = dr[41].ToString();
   //                     meal.strMeasure14 = dr[42].ToString();
   //                     meal.strMeasure15 = dr[43].ToString();
   //                     meal.strMeasure16 = dr[44].ToString();
   //                     meal.strMeasure17 = dr[45].ToString();
   //                     meal.strMeasure18 = dr[46].ToString();
   //                     meal.strMeasure19 = dr[47].ToString();
   //                     meal.strMeasure20 = dr[48].ToString();
   //                     meal.strSource = dr[49].ToString();
   //                     meal.strImageSource = dr[50].ToString();
   //                     meal.strCreativeCommonsConfirmed = dr[51].ToString();
   //                     meal.dateModified = dr[52].ToString();

                        
   //                 }
   //             }

   //             conn.Close();
   //         }

   //         return meal;
   //     }

    }

}

