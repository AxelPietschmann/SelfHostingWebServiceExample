using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost
{
    static class ServiceLocator
    {

        public static void Initalize(IInventoryRepository inventoryRepository)
        {
            InventoryRepository = inventoryRepository ?? throw new ArgumentNullException(nameof(inventoryRepository));
        }

        public static IInventoryRepository InventoryRepository { get; private set; }
    }
}
