using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListWebApi.Models;

namespace ToDoListWebApi.Services
{
    public interface IIventoryServices
    {
        InventoryItems AddInventoryItems(InventoryItems items);
        Dictionary<string, InventoryItems> GetInventoryItems();
    }
}
