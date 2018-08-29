using InventoryLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary.DataAccess
{
    public class DatabaseContext : DbContext
    {
        /// <summary>
        /// A list of all the items in the database.
        /// </summary>
        public DbSet<Item> Items { get; set; }

        /// <summary>
        /// A list of all the categories in the database.
        /// </summary>
        public DbSet<ItemCategory> Categories { get; set; }
    }
}
