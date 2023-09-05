using System;
using Foundation;
using UIKit;
using Xamarin_Sample_App.Home;

namespace Xamarin_Sample_App.Controllers.Product
{
    public class SearchDelegate : UISearchBarDelegate
    {
        private ProductViewController productVC;

        public SearchDelegate(ProductViewController productViewController)
        {
            this.productVC = productViewController;
        }

        [Export("searchBarSearchButtonClicked:")]
        public override void SearchButtonClicked(UISearchBar searchBar)
        {
            Console.WriteLine("Search Button clicked");
            productVC.Search(searchBar);
            searchBar.ResignFirstResponder();
        }

        [Export("searchBarCancelButtonClicked:")]
        public override void CancelButtonClicked(UISearchBar searchBar)
        {
            searchBar.Text = "";
            productVC.Search(searchBar);
            searchBar.ResignFirstResponder();
        }

    }
}

