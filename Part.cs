using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jordan_rowland_inventoryC968
{
    abstract public class Part
    {
        public int PartId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class Inhouse : Part { public int MachineId { get; set; } }
    public class Outsourced : Part { public string CompanyName { get; set; } }
}
