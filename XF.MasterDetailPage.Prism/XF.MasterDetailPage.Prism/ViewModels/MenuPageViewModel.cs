using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XF.MasterDetailPage.Prism.Models;
using XF.MasterDetailPage.Prism.Views;

namespace XF.MasterDetailPage.Prism.ViewModels
{
    public class MenuPageViewModel : BindableBase
    {
        private INavigationService _navigationService;

        public ObservableCollection<MyMenuItem> MenuItems { get; set; }

        private MyMenuItem selectedMenuItem;
        public MyMenuItem SelectedMenuItem
        {
            get => selectedMenuItem;
            set => SetProperty(ref selectedMenuItem, value);
        }

        public DelegateCommand NavigateCommand { get; private set; }

        public MenuPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            MenuItems = new ObservableCollection<MyMenuItem>();

            MenuItems.Add(new MyMenuItem()
            {
                Icon = "explore",
                PageName = nameof(ArticlesPage),
                Title = "Articles"
            });

            MenuItems.Add(new MyMenuItem()
            {
                Icon = "live",
                PageName = nameof(LiveChatPage),
                Title = "Live Chat"
            });

            MenuItems.Add(new MyMenuItem()
            {
                Icon = "gallery",
                PageName = nameof(GalleryPage),
                Title = "Gallery"
            });

            MenuItems.Add(new MyMenuItem()
            {
                Icon = "wishlist",
                PageName = nameof(WishListPage),
                Title = "Wish List"
            });

            MenuItems.Add(new MyMenuItem()
            {
                Icon = "onlineNews",
                PageName = nameof(WishListPage),
                Title = "Explore Online News"
            });

            NavigateCommand = new DelegateCommand(Navigate);
        }

        async void Navigate()
        {
            var navParam = new NavigationParameters();
            navParam.Add("title", SelectedMenuItem.Title);

            await _navigationService.NavigateAsync(nameof(NavigationPage) + "/" + SelectedMenuItem.PageName, navParam);
        }
    }
}
