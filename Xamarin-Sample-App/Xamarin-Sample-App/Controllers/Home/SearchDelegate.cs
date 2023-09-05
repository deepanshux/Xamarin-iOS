using System;
using Foundation;
using UIKit;
using Xamarin_Sample_App.Home;

namespace Xamarin_Sample_App.Controllers.Home
{
    public class SearchDelegate : UISearchBarDelegate
    {
        private HomeViewController homeVC;

        public SearchDelegate(HomeViewController homeViewController)
        {
            this.homeVC = homeViewController;
        }

        [Export("searchBarSearchButtonClicked:")]
        public override void SearchButtonClicked(UISearchBar searchBar)
        {
            Console.WriteLine("Search Button clicked");
            homeVC.Search(searchBar);
            searchBar.ResignFirstResponder();
        }

        [Export("searchBarCancelButtonClicked:")]
        public override void CancelButtonClicked(UISearchBar searchBar)
        {
            searchBar.Text = "";
            homeVC.Search(searchBar);
            searchBar.ResignFirstResponder();
        }

    }
}

