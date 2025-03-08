using CafeMenu.AdminPanel.Core.DTOs;
using CafeMenu.Data.Entities.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.AdminPanel.Core.Services.Interfaces
{
    public interface IItemService 
    {
        public List<Item> GetallItems();

        public bool AddNewItem(CreateItemDTO DTO);
    }
}
