using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrices { get; set; }
        public int Quantity { get; set; }

        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }

        /// <summary>
        /// Retrieve one order item
        /// </summary>
        /// <param name="oderItemId"></param>
        /// <returns></returns>
        public OrderItem Retrieve(int oderItemId)
        {
            // Code tat retrieves the defined order item

            return new OrderItem();
        }

        /// <summary>
        /// Retrieve all order items.
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> Retrieve()
        {
            // Code tat retrieves the defined order item

            return new List<OrderItem>();
        }

        /// <summary>
        /// Validates the order item data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrices == null) isValid = false;

            return isValid;
        }
    }
}
