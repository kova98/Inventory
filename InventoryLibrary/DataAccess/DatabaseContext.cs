using InventoryLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary.DataAccess
{
    class DatabaseContext : DbContext
    {
        /// <summary>
        /// The list of all the items in the database.
        /// </summary>
        public DbSet<Item> Items { get; set; }

        /// <summary>
        /// The list of all stocked items in the inventory.
        /// </summary>
        public DbSet<Item> Inventory { get; set; }
    }
}
