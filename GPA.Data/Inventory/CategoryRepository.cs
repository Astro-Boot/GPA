﻿using GPA.Common.Entities.Inventory;

namespace GPA.Data.Inventory
{
    public interface ICategoryRepository : IRepository<Category>
    {
    }

    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
