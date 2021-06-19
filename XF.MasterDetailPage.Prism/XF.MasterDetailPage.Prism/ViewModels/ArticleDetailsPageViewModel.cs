using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace XF.MasterDetailPage.Prism.ViewModels
{
    public class ArticleDetailsPageViewModel : BaseViewModel
    {
        public ArticleDetailsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Article Details Page";
        }
    }
}
