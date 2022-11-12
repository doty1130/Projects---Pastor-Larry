using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Recipes_B_Logic;
using Recipes_B_Logic.Models;

namespace Backend_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        API_Actions _CallLogic = new API_Actions();
        DataBase_Actions _DataLogic = new DataBase_Actions();

        //Meal Catagorys list.
        List<string> cats = new List<string>();
        List<Meal> Meals = new List<Meal>();
        public MainWindow()
        {
            InitializeComponent();

            cats = _DataLogic.GetCatagory();

            for (int x = 0; x < cats.Count(); x++)
            { CatSelect.Items.Add(cats[x]); }

            
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int i = Convert.ToInt32(NumberPopulate.Text);

            for (int a = 0; a < i; a++)
            {
                Task task = _CallLogic.PopulateDataBaseAtRandom();
            }

        }

        /*
         * Fills Listbox with data from the database.
         * Results are based on the Category you select from the drop down.
         */

        private void Fill_FromCat(object sender, RoutedEventArgs e)
        {
           
            List<string> MealNames = new List<string>();
            MealNames.Clear();
            Meals.Clear();
            Meals.AddRange(_DataLogic.GetMealsByCat(this.CatSelect.Text.ToString()));
           
            foreach (Meal meal in Meals)
            {
                MealNames.Add(meal.strMeal);
            }

            MealList.ItemsSource = null;
            MealList.Items.Clear();
            MealList.ItemsSource = MealNames;
        }


    }
}
