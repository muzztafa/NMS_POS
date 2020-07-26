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
        IFirebaseClient client;
        public string cnt;
        public FirebaseHelper()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "m6NNKfbxyufWFj9YzHObMf2LTPXB9caps9qNjCrs",
                BasePath = "https://nms-pharmacy-e0da6.firebaseio.com/"
            };

            
            client = new FireSharp.FirebaseClient(config);
        }


        public async void test()
        {
            FirebaseResponse resp = await client.GetTaskAsync("Counter/node");
            Counter_class get = resp.ResultAs<Counter_class>();
            this.cnt = get.cnt;
           
        }
    }
}
