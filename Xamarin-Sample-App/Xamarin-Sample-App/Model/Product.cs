using System;
using Foundation;
using System.Collections.Generic;
using Newtonsoft.Json;
using StoreKit;
using System.IO;

namespace Xamarin_Sample_App
{
	public struct Product 
	{
        public string category_id { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string price { get; set; }
        public int qty { get; set; }
    }
    
}

