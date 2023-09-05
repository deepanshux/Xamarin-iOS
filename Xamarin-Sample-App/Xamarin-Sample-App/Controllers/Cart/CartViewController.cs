// This file has been autogenerated from a class added in the UI designer.

using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Xamarin_Sample_App
{
    public partial class CartViewController : UIViewController
	{
        
        AppDelegate appDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;
        Dictionary<int, int> orderCount = new Dictionary<int, int>();
        Product[] products { get; set; }
        List<Product>  cartProducts = new List<Product>();
        public CartViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            UpdateProductsData();
            emptyCartImageView.Hidden = true;
            checkoutBtn.Enabled = true;
            CheckInitialCart();
            UpdateTableview();
            RemoveBadge();
        }

        public void UpdateProductsData()
        {
            products = appDelegate.cartList.ToArray();
        }

        partial void StepperAction(UIStepper sender)
        {
            UpdateQuantity(sender);
        }

        partial void checkoutTap(NSObject sender)
        {
            NavigateToAddress();
        }

        public void UpdateQuantity(UIStepper sender)
        {
            var tag = (int)sender.Tag;
            orderCount[tag] = (int)sender.Value;
            products[tag].qty = orderCount[tag];
            UpdateTableview();
        }

        public void UpdateTableview()
        {
            var cartProducts = new List<Product>();
            foreach (var items in products)
            {
                cartProducts.Add(items);
            }
            cartTableView.Source = new CartTableViewSource(this, cartProducts);
            CalculatePrice(cartProducts);
            
            cartTableView.ReloadData();
        }

        public void CalculatePrice(List<Product> cartProducts)
        {
            var totalPrice = 0;
            foreach(var items in cartProducts)
            {
                totalPrice += Int32.Parse(items.price)* items.qty;
            }
            totalPriceLabel.Text = "Total $ " + totalPrice.ToString();   
        }


        private void NavigateToAddress()
        {
            var addressViewController = Storyboard.InstantiateViewController("AddressViewController") as AddressViewController;
            this.NavigationController.PushViewController(addressViewController, true);
        }

        private void CheckInitialCart()
        {
            if (products.Length == 0)
            {
                emptyCartImageView.Hidden = false;
                checkoutBtn.Enabled = false;
            }
        }

        public void CheckEmptyCart(List<Product> cartProducts)
        {
            if (cartProducts.Count == 0)
            {
                emptyCartImageView.Hidden = false;
                checkoutBtn.Enabled = false;
            }
        }

        private void RemoveBadge()
        {
            var tabItems = TabBarController.TabBar.Items;
            {
                var tabItem = tabItems[1];
                tabItem.BadgeValue = null;
            }
        }
    }
}