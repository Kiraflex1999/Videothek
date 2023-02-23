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

namespace UI.DesktopApp.Pages
{
    /// <summary>
    /// Interaction logic for PageMain.xaml
    /// </summary>
    public partial class PageMain : UserControl
    {
        public PageMain()
        {
            InitializeComponent();
            Messenger.Default.Register<string>(this, (prop) =>
            {
                if (prop.Equals("LogInIsTrue"))
                {
                    IsLogInTrue(true);
                }
                if (prop.Equals("LogInIsFalse"))
                {
                    IsLogInTrue(false);
                }
            });
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send("DataGridLoaded");
        }

        private void IsLogInTrue(bool x)
        {
            if (x) { MainBorder.Visibility = Visibility.Collapsed; BlurEffect.Radius = 0; }
            if (!x) { MainBorder.Visibility = Visibility.Visible; BlurEffect.Radius = 15; }
        }
    }
}
