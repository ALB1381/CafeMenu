using CafeMenu.AdminPanel.Core.Services.Interfaces;
using CafeMenu.Data.Context;
using CafeMenu.Data.Entities.Item;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace CafeMenu.AdminPanel.Core.Services
{
    public class ItemGroupService : IItemGroupService
    {
        CafeContext _Context;
        public ItemGroupService(CafeContext cafe)
        {
            _Context = cafe;
        }

        public async Task<List<SelectListItem>> GetAllExteraOnItemsToSelect()
        {
           return await _Context.ExteraOnItems.Select(c=> new SelectListItem() { Text = c.ExteraTitle,Value = c.ExtraId.ToString()}).ToListAsync();
        }
        public async Task<List<SelectListItem>> GetAllItemGroupsToSelect()
        {
            return await _Context.ItemGroups.Select(c=> new SelectListItem() { Text=c.GroupName,Value= c.GroupId.ToString()}).ToListAsync();
        }

        public async Task<List<SelectListItem>> GetAllMenuTypesToSelect()
        {
            return await _Context.MenuTypes.Select(c=> new SelectListItem() {Text = c.MenuTypeTitle,Value= c.MenuTypeId.ToString() }).ToListAsync();
        }
    }
}
