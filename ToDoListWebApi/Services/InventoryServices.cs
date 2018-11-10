using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListWebApi.Models;

namespace ToDoListWebApi.Services
{
    public class InventoryServices : IIventoryServices
    {
        private readonly Dictionary<string, InventoryItems> _inventoryItems;

        public InventoryServices()
        {
            _inventoryItems = new Dictionary<string, InventoryItems>();
        }

        public InventoryItems AddInventoryItems(InventoryItems items)
        {
            _inventoryItems.Add(items.ItemName, items);

            return items;
        }

        public Dictionary<string, InventoryItems> GetInventoryItems()
        {
            return _inventoryItems;
        }
    }
}
