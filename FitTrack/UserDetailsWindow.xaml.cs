﻿using FitTrack.Classes.BaseClasses;
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

namespace FitTrack
{
    /// <summary>
    /// Interaction logic for UserDetailsWindow.xaml
    /// </summary>
    public partial class UserDetailsWindow : Window
    {
        private UserManagement manager;
        public UserDetailsWindow(UserManagement manager)
        {
            InitializeComponent();
            this.manager = manager;
        }


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); //stänger fönstret.
        }
    }
}
