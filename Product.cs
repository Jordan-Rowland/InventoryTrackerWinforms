﻿using System;
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

        public void AddAssociatedPart(Part part) => AssociatedParts.Add(part);
        public bool RemoveAssociatedPart(int partId)
        {
            Part part = LookupAssociatedPart(partId);
            return AssociatedParts.Remove(part);
        }
        public Part LookupAssociatedPart(int partId) => (Part)AssociatedParts.Where(p => p.PartId == partId).Select(p => p);
    }
}
