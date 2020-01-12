using System.Collections.Generic;

namespace SelfHost
{
    public interface IInventoryRepository
    {
        IReadOnlyList<InventoryItem> GetInventory();
    }
}