using CafeMenu.Core.DTOs;
using CafeMenu.Core.Services.Interfaces;
using CafeMenu.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Core.Services
{
    public class ItemServices : IItemServices
    {
        CafeContext _context;
        public ItemServices(CafeContext cafe)
        {
            _context = cafe;
        }

        public async Task<List<ItemGroupDTO>>? GetAllGroups()
        {
            return await _context.ItemGroups.Select(c=> new ItemGroupDTO() { GroupId=c.GroupId
                ,GroupName = c.GroupName}).ToListAsync();
        }

        public async Task<List<ItemBoxDTO>>? GetItemBoxInformation(int GroupId = 0)
        {
            if (GroupId == 0)
            {
                return await _context.Items.Select(c => new ItemBoxDTO
                {
                    ItemId = c.ItemId,
                    ItemImage = c.ItemImage,
                    ItemIngredient = c.ItemIngredient,
                    Title = c.ItemName,
                    Differences = c.ItemDifferences.Select(q=> new Difference() { DifferenceId = q.DifferenceId,
                        DifferencePrice = q.ItemDifferncePrice,DifferenceTitle = q.DifferenceTitle}).ToList(),
                    Exteras = c.ItemExteraOnItemConnections.Select(g=> new Extera() { ExteraDescription=g.ExteraOnItem.ExteraOnItemDecription,
                        ExteraId = g.ExteraItemId,ExteraPrice = g.ExteraOnItem.ExteraOnItemPrice,
                        ExteraTitle = g.ExteraOnItem.ExteraTitle}).ToList(),
                }).ToListAsync();
            }
            return await _context.Items.Where(c => c.ItemGroupId == GroupId)
                .Select(c => new ItemBoxDTO
                {
                    ItemId = c.ItemId,
                    ItemImage = c.ItemImage,
                    ItemIngredient = c.ItemIngredient,
                    Title = c.ItemName,
                    Differences = c.ItemDifferences.Select(q => new Difference()
                    {
                        DifferenceId = q.DifferenceId,
                        DifferencePrice = q.ItemDifferncePrice,
                        DifferenceTitle = q.DifferenceTitle
                    }).ToList(),
                    Exteras = c.ItemExteraOnItemConnections.Select(g => new Extera()
                    {
                        ExteraDescription = g.ExteraOnItem.ExteraOnItemDecription,
                        ExteraId = g.ExteraItemId,
                        ExteraPrice = g.ExteraOnItem.ExteraOnItemPrice,
                        ExteraTitle = g.ExteraOnItem.ExteraTitle
                    }).ToList(),
                }).ToListAsync();
        }
    }
}