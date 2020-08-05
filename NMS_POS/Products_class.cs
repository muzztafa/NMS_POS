using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMS_POS
{
    public class Products_class
    {

        public Products_class(string des, string disc, bool feat, string img, string name, bool presc, string price, string quantity, string timestamp)
        {
            this.description = des;
            this.discount = disc;
            this.featured = feat;
            this.image = img;
            this.name = name;
            this.prescription = presc;
            this.price = price;
            this.quantity = quantity;
            this.timestamp = timestamp;
            this.avgReviews = "0";
            this.totalReviews = "0";
            //this.keywords = new List<bool>();
            // this.unique = unique;
        }

        public Products_class()
        {
         //   this.keywords = new List<bool>();
        }
        public string description { get; set; }
        public string discount { get; set; }
        public bool featured { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public bool prescription { get; set; }
        public string price { get; set; }
        public string quantity { get; set; }
        public string timestamp { get; set; }
        public string unique { get; set; }
        public string avgReviews { get; set; }
        public string totalReviews { get; set; }
       // public List<bool> keywords { get; set; }
    }


}
