using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jordan_rowland_inventoryC968
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

        public Inventory()
        {
            Inhouse hardcodedPart1 = new Inhouse() { PartId = 1, Name = "Flux Capacitor", Price = 100, InStock = 5, Min = 1, Max = 6, MachineId = 1001 };
            Inhouse hardcodedPart2 = new Inhouse() { PartId = 2, Name = "Transistor", Price = 100, InStock = 5, Min = 1, Max = 6, MachineId = 1002 };
            Inhouse hardcodedPart3 = new Inhouse() { PartId = 3, Name = "Siren Kronos", Price = 100, InStock = 5, Min = 1, Max = 6, MachineId = 1003 };
            AllParts = new BindingList<Part>() { hardcodedPart1, hardcodedPart2, hardcodedPart3 };

            Product hardcodedProduct1 = new Product() {
                ProductId = 1,
                Name = "Delorean",
                Price = 1000,
                InStock = 5,
                Min = 1,
                Max = 6,
                AssociatedParts = new BindingList<Part>() { hardcodedPart1, hardcodedPart2, hardcodedPart3 },
            };
            Products = new BindingList<Product>() { hardcodedProduct1 };
        }
        public void AddProduct(Product product) => Products.Add(product);
        public bool RemoveProduct(Product product) =>Products.Remove(product);
        public Product LookupProduct(int productId) => Products.FirstOrDefault(q => q.ProductId == productId);
        
        public void UpdateProduct(int productId, Product newProduct)
        {
            Product product = LookupProduct(productId);
            product.ProductId = newProduct.ProductId;
            product.Name = newProduct.Name;
            product.InStock = newProduct.InStock;
            product.Price = newProduct.Price;
            product.Min = newProduct.Min;
            product.Max = newProduct.Max;
            product.AssociatedParts = newProduct.AssociatedParts;
        }

        public void AddPart(Part part) => AllParts.Add(part);
        public bool DeletePart(Part part) => AllParts.Remove(part);
        public Part LookupPart(int partId) => AllParts.FirstOrDefault(q => q.PartId == partId);

        // Maybe use 2 functions for this
        public void UpdatePart(int partId, Part newPart)
        {
            Part part = LookupPart(partId);
            DeletePart(part);
            AddPart(newPart);
        }
    }
}
