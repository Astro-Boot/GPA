﻿using GPA.Common.Entities.Inventory;

namespace GPA.Data.Inventory
{
    public interface IProviderRepository : IRepository<Provider>
    {
    }

    public class ProviderRepository : Repository<Provider>, IProviderRepository
    {
        public ProviderRepository(DbContext _dbContext) : base(_dbContext)
        {
        }
    }
}
