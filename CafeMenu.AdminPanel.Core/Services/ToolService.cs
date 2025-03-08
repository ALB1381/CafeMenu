using CafeMenu.AdminPanel.Core.Convertors;
using CafeMenu.AdminPanel.Core.Generator;
using CafeMenu.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CafeMenu.AdminPanel.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CafeMenu.AdminPanel.Core.Services
{
    public class ToolService : IToolService
    {
        CafeContext _context;
        public ToolService(CafeContext cafeContext)
        {
                _context = cafeContext;
        }
        public string[] AddImage(string InProjectPlace, IFormFile Image)
        {
            string[] images = new string[2];
            string GeneratedImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(Image.FileName);
            string ImagePath = Path.Combine(Directory.GetCurrentDirectory(), InProjectPlace, GeneratedImageName);
            using (var ImagePlace = new FileStream(ImagePath, FileMode.Create))
            {
                Image.CopyTo(ImagePlace);
            }
            images[0] = GeneratedImageName;
            images[1] = ImagePath;
            return images;
        }



        public void ResizeImage(int NewWidth, string InputPath, string InProjectPlace, string ImageName, int NewHeight = 0)
        {
            ImageConvertor imageConvertor = new ImageConvertor();
            string NewSizeImagePath = Path.Combine(Directory.GetCurrentDirectory(), InProjectPlace, ImageName);
            imageConvertor.Image_resize(InputPath, NewSizeImagePath, NewWidth, NewHeight);

        }

        public void DeleteImage(string ImageName, string InProjectPlace)
        {
            string ImageFullyPath = Path.Combine(Directory.GetCurrentDirectory(), InProjectPlace, ImageName);
            if (File.Exists(ImageFullyPath))
            {
                File.Delete(ImageFullyPath);
            }
        }

        public int FindNextId(string TableName)
        {
            var res = _context.DeleteHistories.AsNoTracking()
                .FirstOrDefault(c=>c.TableName == TableName);
            return res?.DeletedRowId ?? 0;
        }
    }
}
