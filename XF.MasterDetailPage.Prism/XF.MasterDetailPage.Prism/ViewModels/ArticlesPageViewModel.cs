using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XF.MasterDetailPage.Prism.Models;

namespace XF.MasterDetailPage.Prism.ViewModels
{
    public class ArticlesPageViewModel : BaseViewModel
    {
        public ArticlesPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = " Articles";


            Articles = new ObservableCollection<Article>()
            {
                new Article(){Title = "Amazing Images: ObservableCollection Egypt (HQ) - UAE - KSA – Qatar", BackImage="bg_cover", CreatedBy="by Live.com", Date = DateTime.Now},
                new Article(){Title = "Amazing Images: ObservableCollection Egypt (HQ) - UAE - KSA – Qatar", BackImage="bg_cover", CreatedBy="by Live.com", Date = DateTime.Now},
                new Article(){Title = "Amazing Images: ObservableCollection Egypt (HQ) - UAE - KSA – Qatar", BackImage="bg_cover", CreatedBy="by Live.com", Date = DateTime.Now}
            };
        }

        private ObservableCollection<Article> articles;
        public ObservableCollection<Article> Articles
        {
            get => articles;
            set => SetProperty(ref articles, value);
        }

        public ICommand OpenArticleDetailsCommand => new Command<Article>(OpenArticleDetails);

        private void OpenArticleDetails(Article obj)
        {
            NavigationService.NavigateAsync(nameof(Views.ArticleDetailsPage));
        }
    }
}
