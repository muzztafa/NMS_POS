using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMS_POS
{
   public class Invoices_class
    {

        public string cashier { get; set; }
        public string timestamp { get; set; }
        public string invoiceNo { get; set; }
        public string totalBill { get; set; }
        public List<Products_class> productList { get; set; }
        


    }
}
