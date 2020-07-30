using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace NMS_POS
{
    class FirebaseHelper
    {
        public static List<Products_class> productsList;
        public List<string> keys;
        IFirebaseClient client;
        public string cnt;
        public FirebaseHelper()
        {
            productsList = new List<Products_class>();
            keys = new List<string>();
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "m6NNKfbxyufWFj9YzHObMf2LTPXB9caps9qNjCrs",
                BasePath = "https://nms-pharmacy-e0da6.firebaseio.com/"
            };

            
            client = new FireSharp.FirebaseClient(config);
        }


       

       

        public async void AddProductToInventory(Products_class product)
        {
            PushResponse response = await client.PushTaskAsync("products", product);         

        }

        public  List<Products_class> getAllProducts()
        {
           getProductsFromFirebase();
            Console.WriteLine("fh prodlst size: " + productsList.Count);

            return productsList;
        }

        public async void getProductsFromFirebase()
        {
            FirebaseResponse resp = await client.GetTaskAsync("products/");
            Dictionary<string, Products_class> dict = resp.ResultAs<Dictionary<string, Products_class>>();



            //Adding product keys to Array Keys
            foreach (KeyValuePair<string, Products_class> ele1 in dict)
            {
                keys.Add(ele1.Key);
                // Console.WriteLine("{0} and {1}",
                //  ele1.Key, ele1.Value);
            }

            //traversing list keys to fetch product details
            for (int i = 0; i < keys.Count; i++)
            {
                FirebaseResponse resp2 = await client.GetTaskAsync("products/" + keys[i]);
                Products_class product = resp2.ResultAs<Products_class>();
                productsList.Add(product);
               
                
            }
            Console.WriteLine("size: " + productsList.Count);
        }
    }
}
