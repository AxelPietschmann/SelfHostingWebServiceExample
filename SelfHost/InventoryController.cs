using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHost
{
    public class InventoryController : ApiController
    {
       
        public InventoryItem[] GetAllItems()
        {
            return ServiceLocator.InventoryRepository.GetInventory().ToArray();
        }

    }
}
