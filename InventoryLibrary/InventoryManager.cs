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
        public static void CreateDefaultCategory()
        {
            if (DatabaseConnector.Categories.Count <= 0)
            {
                DatabaseConnector.AddCategory(new ItemCategory { Name = "Default Category" });
            }
        }
    }
}
