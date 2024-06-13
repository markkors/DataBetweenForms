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
using System.Windows.Shapes;

namespace DataBetweenForms.Views
{
    /// <summary>
    /// Interaction logic for FourthWindow.xaml
    /// </summary>
    public partial class FourthWindow : Window
    {
        public FourthWindow()
        {
            InitializeComponent();
            ListBoxData.ItemsSource = App.Students;
            ListBoxData.DisplayMemberPath = "Name";
        }
    }
}
