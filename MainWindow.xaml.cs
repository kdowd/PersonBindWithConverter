using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonBindWithConverter
{

    public partial class MainWindow : Window
    {



        public MainWindow()
        {


            InitializeComponent();

            // Person? temp = PersonInstance.ObjectInstance as Person;
            // temp.Person_Age = 666;


            // Person p =
            // 
            MyPerson.Person_Age = 666;




        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem? temp = sender as MenuItem;
            MessageBox.Show(temp?.Header.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button ?? new Button();

            MessageBox.Show(btn.Content.ToString());
        }
    }
}
