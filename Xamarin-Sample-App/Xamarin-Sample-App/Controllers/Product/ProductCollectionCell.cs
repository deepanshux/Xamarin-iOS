// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Collections.Generic;
using CoreFoundation;
using Foundation;
using UIKit;

namespace Xamarin_Sample_App
{
	public partial class ProductCollectionCell : UICollectionViewCell
	{
		public ProductCollectionCell (IntPtr handle) : base (handle)
		{
		}

        public void UpdateRows(List<Product> products, NSIndexPath indexPath)
        {
            productTitle.Text = products[indexPath.Row].name;
            productPrice.Text = "$ " + products[indexPath.Row].price;
            string imageURL = products[indexPath.Row].image;
            SetImage(imageURL);
        }

        private void SetImage(string url)
        {
            var service = new Services();
            productImage.Image = null;
            service.DownloadImage(url,
            completionBlock: (data) =>
            {
                DispatchQueue.MainQueue.DispatchAsync(() =>
                {
                    productImage.Image = UIImage.LoadFromData(data);
                });
            });
        }
    }
}