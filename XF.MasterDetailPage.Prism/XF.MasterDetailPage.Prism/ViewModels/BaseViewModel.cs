using Prism.Mvvm;
using Prism.Navigation;


namespace XF.MasterDetailPage.Prism.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware
    {

        string _title;
        bool _isBusy;
        int _lang;

        bool _connected;

        public INavigationService NavigationService { get; set; }

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;

            //Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
            Connected = true;
           // IsConncted();

        }

        //private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        //{
        //    if (e.NetworkAccess == NetworkAccess.Internet)
        //    {
        //        Connected = true;
        //    }
        //    else
        //    {
        //        Connected = false;
        //    }
        //}
      

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        public bool Connected
        {
            get => this._connected;
            set => this.SetProperty(ref this._connected, value);
        }


        public bool IsBusy
        {
            get => this._isBusy;
            set => this.SetProperty(ref this._isBusy, value);
        }
       
      

        //public bool IsConncted()
        //{
        //    Connected = Connectivity.NetworkAccess == NetworkAccess.Internet;

        //    return Connected;
        //}

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
           // throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
            {
                Title = parameters["title"].ToString();
            }
           // throw new NotImplementedException();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            //throw new NotImplementedException();
        }
    }
}
