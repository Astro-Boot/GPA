﻿using GPA.Entities;

namespace GPA.Common.Entities.Inventory
{
    public class Category : Entity<Guid>
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
