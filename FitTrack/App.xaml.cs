﻿using FitTrack.Classes.BaseClasses;
using System.Configuration;
using System.Data;
using System.Windows;

namespace FitTrack
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            UserManagement manager = new UserManagement();

            MainWindow window = new MainWindow(manager);
            window.Show();
        }


    }

}
