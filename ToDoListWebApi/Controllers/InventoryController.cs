using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoListWebApi.Models;
using ToDoListWebApi.Services;

namespace ToDoListWebApi.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly InventoryServices _services;

        public InventoryController(InventoryServices services)
        {
            _services = services;
        }

        [HttpPost]
        public ActionResult<InventoryItems> AddInventoryItems(InventoryItems items)
        {
            var inventoryItems = _services.AddInventoryItems(items);

            if (inventoryItems == null)
            {
                return NotFound();
            }

            return inventoryItems;
        }
    }
}