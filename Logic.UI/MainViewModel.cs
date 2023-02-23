using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.Generic;
using System.Windows.Input;

namespace Logic.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private DBService dbService = new DBService();

        public MainViewModel()
        {
            #region DesingMode

            if (IsInDesignMode)
            {
                //MainWindow

                //PageProduct
                _ProductName = "ProductName";
                _ProductDescription = "ProductDescription";
                //PageRegister
            }
            else
            {
                //MainWindow

                //PageProduct
                _ProductName = "ProductName";
                _ProductDescription = "ProductDescription";
                //PageRegister
            }

            #endregion

            Messenger.Default.Register<string>(this, (prop) =>
            {
                if (prop.Equals("DataGridLoaded"))
                {
                    ListDataGrid = dbService.GetAllArticles();
                }
            });
        }

        #region PageMainBinding

        private ICommand _VideoGameButton { get; set; }
        public ICommand VideoGameButton
        {
            get
            {
                if (_VideoGameButton == null)
                {
                    _VideoGameButton = new RelayCommand(() =>
                    {

                    });
                }
                return _VideoGameButton;
            }
        }
        private ICommand _DVDButton { get; set; }
        public ICommand DVDButton
        {
            get
            {
                if (_DVDButton == null)
                {
                    _DVDButton = new RelayCommand(() =>
                    {

                    });
                }
                return _DVDButton;
            }
        }
        private ICommand _BookButton { get; set; }
        public ICommand BookButton
        {
            get
            {
                if (_BookButton == null)
                {
                    _BookButton = new RelayCommand(() =>
                    {

                    });
                }
                return _BookButton;
            }
        }
        private ICommand _MusicCDButton { get; set; }
        public ICommand MusicCDButton
        {
            get
            {
                if (_MusicCDButton == null)
                {
                    _MusicCDButton = new RelayCommand(() =>
                    {

                    });
                }
                return _MusicCDButton;
            }
        }
        private ICommand _BlueRayButton { get; set; }
        public ICommand BlueRayButton
        {
            get
            {
                if (_BlueRayButton == null)
                {
                    _BlueRayButton = new RelayCommand(() =>
                    {

                    });
                }
                return _BlueRayButton;
            }
        }
        private ICommand _LogOutButton { get; set; }
        public ICommand LogOutButton
        {
            get
            {
                if (_LogOutButton == null)
                {
                    _LogOutButton = new RelayCommand(() =>
                    {
                        //Messenger.Default.Send(new NavigationMessage("PageLogIn"));
                    });
                }
                return _LogOutButton;
            }
        }
        private ICommand _RegisterButton { get; set; }
        public ICommand RegisterButton
        {
            get
            {
                if (_RegisterButton == null)
                {
                    _RegisterButton = new RelayCommand(() =>
                    {
                        Messenger.Default.Send(new NavigationMessage("PageRegister"));
                    });
                }
                return _RegisterButton;
            }
        }
        private ICommand _MyProductsButton { get; set; }
        public ICommand MyProductsButton
        {
            get
            {
                if (_MyProductsButton == null)
                {
                    _MyProductsButton = new RelayCommand(() =>
                    {

                    });
                }
                return _MyProductsButton;
            }
        }

        #endregion

        #region PageProductBinding

        private string _ProductName { get; set; }
        public string ProduktName
        {
            get { return _ProductName; }
            set { _ProductName = value; RaisePropertyChanged("_ProduktName"); }
        }
        private string _ProductDescription { get; set; }
        public string ProduktDescription
        {
            get { return _ProductDescription; }
            set { _ProductDescription = value; RaisePropertyChanged("_ProduktDescription"); }
        }

        #endregion

        #region PageRegisterBinding

        private ICommand _AccountCreateButton { get; set; }
        public ICommand AccountCreateButton
        {
            get
            {
                if (_AccountCreateButton == null)
                {
                    _AccountCreateButton = new RelayCommand(() =>
                    {

                    });
                }
                return _AccountCreateButton;
            }
        }
        private ICommand _RegisterCancelButton { get; set; }
        public ICommand RegisterCancelButton
        {
            get
            {
                if (_RegisterCancelButton == null)
                {
                    _RegisterCancelButton = new RelayCommand(() =>
                    {
                        Messenger.Default.Send(new NavigationMessage("PageMain"));
                    });
                }
                return _RegisterCancelButton;
            }
        }

        #endregion

        #region PageLogInBinding

        //private ICommand _LogInConfirmButton { get; set; }
        //public ICommand LogInConfirmButton
        //{
        //    get
        //    {
        //        if (_LogInConfirmButton == null)
        //        {
        //            _LogInConfirmButton = new RelayCommand(() =>
        //            {

        //            });
        //        }
        //        return _LogInConfirmButton;
        //    }
        //}
        private ICommand _LogInCancelButton { get; set; }
        public ICommand LogInCancelButton
        {
            get
            {
                if (_LogInCancelButton == null)
                {
                    _LogInCancelButton = new RelayCommand(() =>
                    {
                        Messenger.Default.Send(new NavigationMessage("PageMain"));
                    });
                }
                return _LogInCancelButton;
            }
        }

        #endregion

        #region WindowLogInBinding

        private ICommand _LogInConfirmButton { get; set; }
        public ICommand LogInConfirmButton
        {
            get
            {
                if (_LogInConfirmButton == null)
                {
                    _LogInConfirmButton = new RelayCommand(() =>
                    {

                    });
                }
                return _LogInConfirmButton;
            }
        }

        #endregion

        #region DatabaseBinding

        private List<Article> _ListDataGrid;
        public List<Article> ListDataGrid
        {
            get { return _ListDataGrid; }
            set { _ListDataGrid = value; RaisePropertyChanged("ListDataGrid"); }
        }

        private Article _SelectedArticle;
        public Article SelectedArticle
        {
            get { return _SelectedArticle; }
            set { _SelectedArticle = value; RaisePropertyChanged("SelectedArticle"); }
        }

        #endregion
    }
}