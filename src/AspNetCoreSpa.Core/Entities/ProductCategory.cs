﻿using System.Collections.Generic;

namespace MyCommunity.Core.Entities
{
    public class ProductCategory : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
