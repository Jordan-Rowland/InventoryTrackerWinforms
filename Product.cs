using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jordan_rowland_inventoryC968
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product()
        {
            // Add some Probably have a way to init the asst parts list
            //AssociatedParts = new BindingList<Part>() { hardcodedPart1 };
        }

        public void addAssociatedPart(Part part) {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(Part part) {
            AssociatedParts.Remove(part);
            return true;
        }

        public Part lookupAssociatedPart(int partId) {
            return (Part)AssociatedParts.Where(p => p.PartId == partId).Select(p => p);
        }
    }

}
