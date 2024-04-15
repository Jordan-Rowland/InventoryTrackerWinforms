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
        public void addProduct(Product product) => Products.Add(product);
        public bool removeProduct(Product product)
        {
            return false;
        }
        public Product lookupProduct(int productId) => Products.FirstOrDefault(q => q.ProductId == productId);

        public void addPart(Part part) => AllParts.Add(part);
        public bool deletePart(Part part)
        {
            AllParts.Remove(part);
            return false;
        }
        public Part lookupPart(int partId) => AllParts.FirstOrDefault(q => q.PartId == partId);

        // Maybe use 2 functions for this
        public void updatePart(int partId, Part newPart)
        {
            Part part = lookupPart(partId);
            dynamic updatedPart;
            dynamic parsedNewPart;

            // Add checking for switching from Inhouse to Outsourced,
            // or try breaking the function up into 2 - overloading
            try
            {
                updatedPart = (Inhouse)part;
                parsedNewPart = (Inhouse)newPart;
                updatedPart.MachineId = parsedNewPart.MachineId;
            }
            catch
            {
                updatedPart = (Outsourced)part;
                parsedNewPart = (Outsourced)newPart;
                updatedPart.CompanyName = parsedNewPart.CompanyName;
            }

            updatedPart.PartId = newPart.PartId;
            updatedPart.Name = newPart.Name;
            updatedPart.InStock = newPart.InStock;
            updatedPart.Price = newPart.Price;
            updatedPart.Min = newPart.Min;
            updatedPart.Max = newPart.Max;
        }
    }
}
