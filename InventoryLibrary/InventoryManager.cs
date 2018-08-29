using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryLibrary.DataAccess;
using InventoryLibrary.Models;

namespace InventoryLibrary
{
    public class InventoryManager
    {
        public InventoryManager()
        {
            using (var db = new DatabaseContext())
            {
                if (db.Categories.Count() <= 0)
                {
                    db.Categories.Add(new ItemCategory { Name = "Default Category" });
                    db.SaveChanges();
                }
            }
        }
    }
}
