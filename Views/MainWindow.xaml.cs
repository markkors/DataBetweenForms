using DataBetweenForms.models;
using DataBetweenForms.Views;
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

namespace DataBetweenForms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly List<Student> list = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            // add 3 students to list
            list.Add(new Student { Name = "John", Surname = "Doe", Age = 25 });
            list.Add(new Student { Name = "Jane", Surname = "Doe", Age = 22 });
            list.Add(new Student { Name = "Jack", Surname = "Doe", Age = 20 });

           

            // set source for datagrid to list
            // 
            MyData.ItemsSource = list;
            MyData.DisplayMemberPath = Name;

        }

        private void ButtonOpenWindows_Click(object sender, RoutedEventArgs e)
        {
            // via de constructor
            SecondWindow sw = new SecondWindow(list);
            sw.Show();

            // via een methode van een window instance
            ThirdWindow tw = new ThirdWindow();
            tw.SetData(list);
            tw.Show();


            // via een static property uit de app class
            App.Students = list;
            FourthWindow fw = new FourthWindow();
            fw.Show();


        }
    }
}
