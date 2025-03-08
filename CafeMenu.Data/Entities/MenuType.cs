using CafeMenu.Data.Entities.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities
{
    public class MenuType
    {
        [Key]
        [Column(TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MenuTypeId { get; set; }

        [Column(TypeName = "nvarchar(60)")]
        public string MenuTypeTitle { get; set; }

        public List<slectlistitem> ItemGroups { get; set; }
        public bool IsDeleted { get; set; }
    }
}
