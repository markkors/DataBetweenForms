﻿using DataBetweenForms.models;
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
    /// Interaction logic for ThirdWindow.xaml
    /// </summary>
    public partial class ThirdWindow : Window
    {
        public ThirdWindow()
        {
            InitializeComponent();
        }

        public void SetData(List<Student> lst)
        {
            ListBoxData.ItemsSource = lst;
            ListBoxData.DisplayMemberPath = "Name";
        }

        public bool setDataTwee(List<Student> lst)
        {
            ListBoxData.ItemsSource = lst;
            ListBoxData.DisplayMemberPath = "Name";
            return false;
        }
    }
}
