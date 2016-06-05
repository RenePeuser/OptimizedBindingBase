﻿using System.Windows;

namespace OptimizedBindingBase
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = new MainWindow { DataContext = new MainWindowViewModel() };
            mainWindow.Show();
        }
    }
}
