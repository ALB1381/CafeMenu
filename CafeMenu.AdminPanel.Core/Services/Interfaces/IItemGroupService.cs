using CafeMenu.Data.Entities.Item;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.AdminPanel.Core.Services.Interfaces
{
    public interface IItemGroupService
    {
        public Task<List<SelectListItem>> GetAllItemGroupsToSelect();
        public Task<List<SelectListItem>> GetAllMenuTypesToSelect();
        public Task<List<SelectListItem>> GetAllExteraOnItemsToSelect();
    }
}
