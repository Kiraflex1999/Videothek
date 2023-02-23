using GalaSoft.MvvmLight.Messaging;
using Logic.UI;
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
using UI.DesktopApp.Pages;
using UI.DesktopApp.Windows;

namespace UI.DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigateToPage();
            NavigateToPage("WindowLogIn");

            Messenger.Default.Register<NavigationMessage>(this, msg =>
            {
                NavigateToPage(msg.Page);
            });
        }
        private void NavigateToPage(string page = null)
        {
            switch (page)
            {
                case "PageMain":
                    MainContent.Content = new PageMain();
                    break;
                case "PageProduct":
                    MainContent.Content = new PageProduct();
                    break;
                case "PageRegister":
                    MainContent.Content = new PageRegister();
                    break;
                case "PageLogIn":
                    MainContent.Content = new PageLogIn();
                    break;
                case "WindowLogIn":
                    WindowLogIn windowLogIn = new WindowLogIn();
                    windowLogIn.Show();
                    break;
                default:
                    MainContent.Content = new PageMain();
                    break;
            }
        }
    }
}
