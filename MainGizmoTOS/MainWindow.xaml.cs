using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
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
using Client;
using SharedLib;

namespace MainGizmoTOS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {

        public bool testb = false;

        private void OnLoginStateChange(object sender, UserEventArgs e)
        {


            if (e.State.HasFlag(LoginState.LoginCompleted))
            {

                if(e.UserProfile.PostCode != null)
                {
                    CloseGUI();

                }
                else
                {
                    Test(sender, e);
                    e.UserProfile.PostCode = "yes";
                }

            }


        }

        public MainWindow()
        {
            InitializeComponent();
        }


        public void Test(object sender, UserEventArgs e)
        {

            while (true)
            {
                if (testb)
                {
                    DateTime dateTime = DateTime.UtcNow.Date;
                    e.UserProfile.PostCode = dateTime.ToString("ddMMyyyy");

                    testb = false;
                    CloseGUI();

                }

            }


        }

        private void Click_Yes(object sender, RoutedEventArgs e)
        {

            //import Date to user
            WriteDate();

        }

        private void Click_No(object sender, RoutedEventArgs e)
        {
            CloseGUI();
        }

        public void WriteDate() {

            //Write Date to User    
            testb = true;
        
        }

        public void CloseGUI()
        {
            this.Close();
        }

  

    }
}



