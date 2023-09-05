﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Xamarin_Sample_App
{
    public class CategoryService
    {
        public List<CategoryModel> getData()
        {
            var json = new Items();
            using (StreamReader reader = new StreamReader(Services.FilePath))
            {
                var serializer = new JsonSerializer();
                json = (Items)serializer.Deserialize(reader, typeof(Items));
            }
            return json.categories;
        }
    }
}

