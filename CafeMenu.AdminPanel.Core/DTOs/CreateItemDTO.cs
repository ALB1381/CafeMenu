using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.AdminPanel.Core.DTOs
{
    public class CreateItemDTO
    {
        [Required(ErrorMessage ="{0} Should not be empty")]
        public IFormFile ItemImage { get; set; }

        [Required(ErrorMessage = "{0} Should not be empty")]
        [Column(TypeName = "nvarchar(60)")]
        [MaxLength(60,ErrorMessage ="The {0} should be less then {1}")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "{0} Should not be empty")]
        [Column(TypeName = "nvarchar(160)")]
        [MaxLength(160, ErrorMessage = "The {0} should be less then {1}")]
        public string ItemIngredient { get; set; }

        [Required(ErrorMessage = "{0} Should not be empty")]
        public int ItemGroupId { get; set; }

        [Required(ErrorMessage = "{0} Should not be empty")]
        public int MenuTypeID { get; set; }

        public List<int>? ExteraOnItems { get; set; }
    }
}
