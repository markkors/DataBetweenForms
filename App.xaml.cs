using DataBetweenForms.models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DataBetweenForms
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 

    
    public partial class App : Application
    {
      
        public static List<Student> Students { get; set; }
    }
}
