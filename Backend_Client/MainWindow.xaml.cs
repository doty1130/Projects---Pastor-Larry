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
        public MainWindow()
        {
            InitializeComponent();

            cats = _DataLogic.GetCatagory();

            for (int x = 0; x < cats.Count(); x++)
            { List.Items.Add(cats[x]); }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Task task = _CallLogic.PopulateDataBaseAtRandom();


        }

       
    }
}
