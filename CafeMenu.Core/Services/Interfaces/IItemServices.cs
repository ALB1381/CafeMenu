using CafeMenu.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace CafeMenu.Core.Services.Interfaces
{
    public interface IItemServices 
    {
       public Task<List<ItemBoxDTO>>? GetItemBoxInformation(int GroupId=0);
        public Task<List<ItemGroupDTO>>? GetAllGroups();

    }
}
