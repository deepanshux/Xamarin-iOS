using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreFoundation;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Essentials;

namespace Xamarin_Sample_App
{
	public class Services
	{
        public static string FilePath = "./Services/Data.json";
        
        public async void DownloadImage(string url,Action<NSData> completionBlock)
        {
            NSUrlSession session = NSUrlSession.SharedSession;
            var downloadTask = await session.CreateDataTaskAsync(NSUrl.FromString(url));
            
            if (downloadTask != null)
            {
                NSData data = downloadTask.Data;
                completionBlock(data);
            }     
        }
    }

    public class NSObjectWrapper : NSObject
    {
        public object Context;

        public NSObjectWrapper (object obj) :  base()
        {
            this.Context = obj;
        }

        public static NSObjectWrapper Wrap(Object obj)
        {
            return new NSObjectWrapper(obj);
        }
    }

    public class Provider 
    {
        public NSObject obj;

        public Provider(NSObject myObj) : base()
        {
            this.obj = myObj;
        }

        public NSObject encode(NSObject obj)
        {
            var coder = new NSCoder();
            coder.Encode(obj);
            return obj; 
        }

         
    }
}


