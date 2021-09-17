using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Client;
using SharedLib;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MainGizmoTOS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Create the window
            MainWindow window = new MainWindow();

            window.Show();

        }




    }



}
