using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMS_POS
{
    public class PurchaseOrder_class
    {
        public string orderNo { get; set; }
        public string orderDate { get; set; }
        public string totalBill { get; set; }
        public Vendor_class vendor { get; set; }
        public List<Products_class> productList { get; set; }
        public string punchedBy { get; set; }
    }
}
