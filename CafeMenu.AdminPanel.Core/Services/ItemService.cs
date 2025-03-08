using CafeMenu.AdminPanel.Core.DTOs;
using CafeMenu.AdminPanel.Core.Services.Interfaces;
using CafeMenu.Data.Context;
using CafeMenu.Data.Entities.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.AdminPanel.Core.Services
{
    public class ItemService : IItemService
    {
        CafeContext _Context;
        IToolService _toolService;
        public ItemService(CafeContext cafeContext,IToolService tool)
        {
            _Context = cafeContext;
            _toolService = tool;
        }

        public bool AddNewItem(CreateItemDTO DTO)
        {
            if (DTO.ItemImage != null)
            {
                string[] Out = _toolService.AddImage("wwwroot/ItemImages/Orginal", DTO.ItemImage);
                int Id = _toolService.FindNextId("Item");
                if (Id == 0)
                {
                    Id = _Context.Items.Last().ItemId + 1;
                    Item item = new Item()
                    {
                        ItemName = DTO.ItemName,
                        ItemGroupId = DTO.ItemGroupId,
                        ItemIngredient = DTO.ItemIngredient,
                        IsDeleted = false,
                        ItemId = Id,
                        ItemImage = Out[0]
                    };
                }
            }
            return false;
          
        }

        public List<Item> GetallItems()
        {
            return _Context.Items.ToList();
        }
       
    }
}
