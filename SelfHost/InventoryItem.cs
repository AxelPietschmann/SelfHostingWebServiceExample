using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Count { get; set; }
    }
}
