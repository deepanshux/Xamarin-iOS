using System;
using UIKit;
using Foundation;
using System.Collections.Generic;
using Xamarin_Sample_App.Home;

namespace Xamarin_Sample_App
{
	public class ProductCollectionViewSource : UICollectionViewSource
	{
        private ProductViewController productVc;
        private List<Product> products;

        public ProductCollectionViewSource(ProductViewController productVc, List<Product> products)
        {
            this.productVc = productVc;
            this.products = products;
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return products.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = collectionView.DequeueReusableCell("ProductCell", indexPath) as ProductCollectionCell;
            
            cell.UpdateRows(products, indexPath);
            return cell;
        }

        [Export("collectionView:didSelectItemAtIndexPath:")]
        public override void ItemSelected(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var product = products[indexPath.Row];
            productVc.NavigateToDetails(product);
        }
    }
}

