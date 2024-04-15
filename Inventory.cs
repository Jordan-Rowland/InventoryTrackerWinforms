using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jordan_rowland_inventoryC968
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

        public Inventory()
        {
            Inhouse hardcodedPart1 = new Inhouse() { PartId = 1, Name = "Flux Capacitor", Price = 100, InStock = 5, Min = 1, Max = 6 };
            Inhouse hardcodedPart2 = new Inhouse() { PartId = 2, Name = "Transistor", Price = 100, InStock = 5, Min = 1, Max = 6 };
            Inhouse hardcodedPart3 = new Inhouse() { PartId = 3, Name = "Siren Kronos", Price = 100, InStock = 5, Min = 1, Max = 6 };
            AllParts = new BindingList<Part>() { hardcodedPart1, hardcodedPart2, hardcodedPart3 };

            Product hardcodedProduct1 = new Product() { ProductId = 1, Name = "Delorean", Price = 1000, InStock = 5, Min = 1, Max = 6 };
            Products = new BindingList<Product>() { hardcodedProduct1 };
        }
        public void addProduct(Product product) { }
        public bool removeProduct(Product product) { return false; }
        //public Product lookupProduct(int productId) { }
        public void addPart(Part part)
        {
            AllParts.Add(part);
        }
        public bool deletePart(Part part) { return false; }
        //public Part lookupPart(int partId) { }
        public void updatePart(int partId, Part newPart) { }
    }
}
