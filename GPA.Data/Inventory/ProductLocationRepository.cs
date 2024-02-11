﻿using GPA.Common.Entities.Inventory;

namespace GPA.Data.Inventory
{
    public interface IProductLocationRepository : IRepository<ProductLocation>
    {
    }

    public class ProductLocationRepository : Repository<ProductLocation>, IProductLocationRepository
    {
        public ProductLocationRepository(DbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
