using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost
{
    class InventoryRepository : IInventoryRepository
    {

        private readonly object _Lock = new object();
        private readonly List<InventoryItem> _Inventory;

        public InventoryRepository()
        {
            _Inventory = new List<InventoryItem>
            {
                new InventoryItem { Id = 1, Name = "Milk", Count = 98 },
                new InventoryItem { Id = 2, Name = "Wine", Count = 18 },
                new InventoryItem { Id = 3, Name = "Water", Count = 478 },
                new InventoryItem { Id = 4, Name = "Bread", Count = 10 },
                new InventoryItem { Id = 4, Name = "Soup", Count = 54 },
            };
        }

        public IReadOnlyList<InventoryItem> GetInventory()
        {
            lock (_Lock)
            {
                return _Inventory.ToList();
            }
        }

    }
}
