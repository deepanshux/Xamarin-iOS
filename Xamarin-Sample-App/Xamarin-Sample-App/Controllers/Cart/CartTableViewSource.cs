using System;
using Foundation;
using UIKit;
using System.Collections.Generic;

namespace Xamarin_Sample_App
{
	public class CartTableViewSource : UITableViewSource
	{
        private CartViewController cartVC;
        List<Product> products = new List<Product>();
        AppDelegate appDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;

        public CartTableViewSource(CartViewController cartViewController, List<Product> products)
		{
            this.cartVC = cartViewController;
            this.products = products;
		}

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("cartCell", indexPath) as CartTableViewCell;
            cell.UpdateRowsAsync(products, indexPath);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return products.Count;
        }

        public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
        {
            if (editingStyle == UITableViewCellEditingStyle.Delete)
            {
                products.RemoveAt(indexPath.Row);
                appDelegate.cartList.RemoveAt(indexPath.Row);
                tableView.DeleteRows(new NSIndexPath[] {indexPath}, UITableViewRowAnimation.Fade);
                cartVC.CalculatePrice(products);
                cartVC.CheckEmptyCart(products);
                cartVC.UpdateProductsData();
            }    
        }
    }
}

