using Foundation;
using System;
using UIKit;
using KountDataCollector;
using Xamarin;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace Xamarin_Sample_App
{ 
    
    public partial class ViewController : KountAnalyticsViewController
    {
        UIViewController loginViewController;
        
        public ViewController (IntPtr handle) : base (handle)
        {

        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib
            KountSetup();
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void AwakeFromNib()
        {
            this.Initialize();
        }

        partial void goButton(NSObject sender)
        {
            NavigateToLogin();
        }

        private void KountSetup()
        {
            // Method to call Kount Data collector and it's configurations.
            KountDataCollector.KDataCollector.SharedCollector.MerchantID = 900900;
            KountDataCollector.KDataCollector.SharedCollector.Environment = KountDataCollector.KEnvironment.Test;
            KountDataCollector.KDataCollector.SharedCollector.Debug = true;
            KountDataCollector.KDataCollector.SharedCollector.LocationCollectorConfig = KountDataCollector.KLocationCollectorConfig.RequestPermission;
            KountDataCollector.KountAnalyticsViewController.SharedInstance.SetEnvironmentForAnalytics(KountDataCollector.KDataCollector.SharedCollector.Environment);

            KountDataCollector.KountAnalyticsViewController.SharedInstance.Collect(SessionID, true,
                completionBlock: (sessionID, success, error) =>
                {
                    if (success)
                    {
                        Console.WriteLine("Collection Successful");
                    }
                    else
                    {
                        if (error != null)
                        {
                            Console.WriteLine("Collection Failed with error ", error);
                        }
                        else
                        {
                            Console.WriteLine("Collection failed without error");
                        }
                    }
                }
                );
        }

        private void NavigateToLogin()
        {    
            this.NavigationController.PushViewController(loginViewController,true);
        }

        public void Initialize()
        {
            loginViewController = Storyboard.InstantiateViewController("LoginViewController") as LoginViewController;
        }

    }
}
