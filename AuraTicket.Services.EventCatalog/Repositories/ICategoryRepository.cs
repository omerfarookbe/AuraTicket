﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using AuraTicket.Services.EventCatalog.Entities;

namespace AuraTicket.Services.EventCatalog.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryById(string categoryId);
    }
}