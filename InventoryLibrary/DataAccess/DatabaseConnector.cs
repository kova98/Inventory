using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using InventoryLibrary.Models;

namespace InventoryLibrary.DataAccess
{
    class DatabaseConnector
    {
        /// <summary>
        /// Adds a new item to the database.
        /// </summary>
        /// <param name="item">The item to add</param>
        public static void AddItemToDatabase(Item item)
        {
            using (var db = new DatabaseContext())
            {
                db.Items.Add(item);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Removes an item from the database.
        /// </summary>
        /// <param name="item">The item to remove</param>
        public static void RemoveItemFromDatabase(Item item)
        {
            using (var db = new DatabaseContext())
            {
                db.Items.Remove(item);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Adds a certain amount of the given item to the inventory.
        /// </summary>
        /// <param name="item">The item to add</param>
        /// <param name="amount">The amount to add</param>
        public static void AddItemToInventory(Item item, int amount)
        {
            using (var db = new DatabaseContext())
            {
                db.Inventory.Add(item);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Removes a certain amount of the given item from the inventory.
        /// </summary>
        /// <param name="item">The item to remove</param>
        /// <param name="amount">The amount to remove</param>
        public static void RemoveItemFromInventory(Item item, int amount)
        {
            using (var db = new DatabaseContext())
            {
                var itemToRemove = db.Inventory.Find(item);

                if (itemToRemove.Amount - amount <= 0)
                {
                    db.Inventory.Remove(item);
                }
                else
                {
                    itemToRemove.Amount -= amount;
                }

                db.SaveChanges();
            }
        }

        /// <summary>
        /// Edits an item in the database.
        /// Returns false if the item doesn't exist.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool TryEditItem(Item item)
        {
            using (var db = new DatabaseContext())
            {
                var itemToEdit = db.Inventory.Find(item);
                if (itemToEdit != null)
                {
                    itemToEdit.Name = item.Name;
                    itemToEdit.Category = item.Category;
                    itemToEdit.Company = item.Company;
                    itemToEdit.Price = item.Price;

                    db.SaveChanges();

                    return true;
                } 
                else
                {
                    return false;
                }
            }
        }
        
    }
}
