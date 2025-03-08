using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.AdminPanel.Core.Services.Interfaces
{
    public interface IToolService
    {
        public int FindNextId(string TableName);
        public void ResizeImage(int NewWidth, string InputPath, string InProjectPlace, string ImageName, int NewHeight = 0);
        public string[] AddImage(string InProjectPlace, IFormFile Image);
        public void DeleteImage(string ImageName, string InProjectPlace);
    }
}
