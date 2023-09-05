using System;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace Xamarin_Sample_App.Home
{
	public class CategoryCollectionViewSource: UICollectionViewSource
	{
        private HomeViewController homeVC;
        private List<CategoryModel> category;

        public CategoryCollectionViewSource(HomeViewController homeVC, List<CategoryModel> category)
        {
            this.homeVC = homeVC;
            this.category = category;
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

     
        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return category.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = collectionView.DequeueReusableCell("CategoryCell", indexPath) as CategoryCollectionViewCell;
            cell.UpdateRows(category, indexPath);
            return cell;
        }

        [Export("collectionView:didSelectItemAtIndexPath:")]
        public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
        {
            string categoryLabel = category[indexPath.Row].categoryID;
            homeVC.NavigateToProducts(categoryLabel);
        }
    }
}

