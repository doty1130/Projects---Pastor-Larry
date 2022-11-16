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
       
        List<Datum> Meals = new List<Datum>();
        public MainWindow()
        {
            InitializeComponent();
  
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int i = Convert.ToInt32(NumberPopulate.Text);

            for (int a = 0; a < i; a++)
            {
                Task task = _CallLogic.PopulateDataBase("Tomato Soup", 10);
            }

        }
    }
}
