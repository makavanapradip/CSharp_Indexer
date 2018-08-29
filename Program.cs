using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.pradip.com
{
    public class OrderDetail
    {
        public decimal Order_amount { get; set; }
        public DateTime Order_Date { get; set; }
        public string Order_ItemName { get; set; }
        public int Order_Discount { get; set; }
        public bool Order_Is_Dispatched { get; set; }
    }
    public class PurchaseOrder
    {
        private List<OrderDetail> _PurchaseOrder_List = new List<OrderDetail>();
        public PurchaseOrder()
        {
            _PurchaseOrder_List.Add(new OrderDetail { Order_amount = 15000, Order_Date = DateTime.Now, Order_ItemName = "Deo", Order_Discount = 10, Order_Is_Dispatched = true });
            _PurchaseOrder_List.Add(new OrderDetail { Order_amount = 25000, Order_Date = DateTime.Now, Order_ItemName = "Car", Order_Discount = 15, Order_Is_Dispatched = false });
            _PurchaseOrder_List.Add(new OrderDetail { Order_amount = 30000, Order_Date = DateTime.Now.AddDays(-2), Order_ItemName = "Bike", Order_Discount = 20, Order_Is_Dispatched = true });
            _PurchaseOrder_List.Add(new OrderDetail { Order_amount = 35000, Order_Date = DateTime.Now.AddMonths(-1), Order_ItemName = "Shirt", Order_Discount = 25, Order_Is_Dispatched = false });
            _PurchaseOrder_List.Add(new OrderDetail { Order_amount = 36000, Order_Date = DateTime.Now.AddHours(-10), Order_ItemName = "Shirt", Order_Discount = 25, Order_Is_Dispatched = true });
        }

        public OrderDetail this[int amount]
        {
            get
            {
                foreach (OrderDetail p in _PurchaseOrder_List)
                {
                    if (p.Order_amount == amount)
                    {
                        return p;
                    }
                }
                return null;
            }
        }
        public OrderDetail this[string Item]
        {
            get
            {
                foreach (OrderDetail p in _PurchaseOrder_List)
                {
                    if (p.Order_ItemName == Item)
                    {
                        return p;
                    }
                }
                return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PurchaseOrder _purchaseOrder = new PurchaseOrder();
            OrderDetail p = _purchaseOrder[36000];
            OrderDetail p1 = _purchaseOrder["Deo"];
        }
    }
}
