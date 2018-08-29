﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using InventoryLibrary.Models;

namespace InventoryLibrary.DataAccess
{
    public class DatabaseConnector
    {
        public static List<ItemCategory> Categories
        {
            get
            {
                using (var db = new DatabaseContext())
                {
                    return db.Categories.ToList();
                }
            }
        }

        public static List<Item> Items
        {
            get
            {
                using (var db = new DatabaseContext())
                {
                    return db.Items.ToList();
                }
            }
        }

        /// <summary>
        /// Adds a new item to the database.
        /// </summary>
        /// <param name="item">The item to add</param>
        public static void AddItem(Item item)
        {
            using (var db = new DatabaseContext())
            {
                db.Items.Add(item);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes an item from the database.
        /// </summary>
        /// <param name="item">The item to remove</param>
        public static void DeleteItem(Item item)
        {
            using (var db = new DatabaseContext())
            {
                db.Items.Remove(item);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Removes a certain amount of the given item from the inventory.
        /// </summary>
        /// <param name="item">The item to remove</param>
        /// <param name="amount">The amount to remove</param>
        public static void RemoveItem(Item item, int amount)
        {
            using (var db = new DatabaseContext())
            {
                var itemToRemove = db.Items.Find(item);

                itemToRemove.Amount -= amount;

                if (itemToRemove.Amount - amount < 0)
                {
                    itemToRemove.Amount = 0;
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
                var itemToEdit = db.Items.Find(item);
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

        /// <summary>
        /// Adds a new category to the database.
        /// </summary>
        /// <param name="category"></param>
        public static void AddCategory(ItemCategory category)
        {
            using (var db = new DatabaseContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
        }
        
        /// <summary>
        /// Deletes a category from the database.
        /// </summary>
        /// <param name="category"></param>
        public static void DeleteCategory(ItemCategory category)
        {
            using (var db = new DatabaseContext())
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Edits a category in the database.
        /// Returns false if the category doesn't exist.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public static bool TryEditCategory(ItemCategory category)
        {
            using (var db = new DatabaseContext())
            {
                var categoryToFind = db.Categories.Find(category);

                if (categoryToFind != null)
                {
                    categoryToFind.Name = category.Name;
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