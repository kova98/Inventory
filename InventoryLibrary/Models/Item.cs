using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary.Models
{
    public class Item
    {
        /// <summary>
        /// The ID of the item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The category of the item.
        /// </summary>
        public virtual ItemCategory Category { get; set; }

        /// <summary>
        /// The company that produced the item.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// The price of the item.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The amount of items available.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// The category name.
        /// </summary>
        public string CategoryName
        {
            get
            {
                if (Category != null) 
                {
                    return Category.Name;
                }
                else
                {
                    return "";
                }
            }
        }
    }
}
