using CafeMenu.Design.Assembly.Core.DTOs;
using CafeMenu.Design.Assembly.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CafeMenu.Design.Assembly.Core.Services
{
    public class ItemServices : IItemServices
    {
        HttpClient HttpClient;
        public ItemServices(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<List<ItemGroupDTO>>? GetAllGroups()
        {
            return await HttpClient.GetFromJsonAsync<List<ItemGroupDTO>>($"https://localhost:7103/api/Item/GetGroups");
        }

        public async Task<List<ItemBoxDTO>>? GetItemBoxInformation(int GroupId = 0)
        {
            return await HttpClient.GetFromJsonAsync<List<ItemBoxDTO>>($"https://localhost:7103/api/Item?GroupId={GroupId}");
        }
    }
}