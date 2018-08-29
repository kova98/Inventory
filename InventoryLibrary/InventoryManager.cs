using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryLibrary.Models;

namespace InventoryLibrary
{
    public class InventoryManager
    {
        public static List<Item> Stock { get; set; } = new List<Item>();

        public InventoryManager()
        {
            
        }

    }
}
