using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Item
{
    public class slectlistitem
    {
        [Key]
        [Column(TypeName = "tinyint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupId { get; set; }

        [Column(TypeName = "nvarchar(60)")]
        public string GroupName { get; set; }

        [Column(TypeName = "tinyint")]
        public int MenuTypeId { get; set; }
        
        [ForeignKey("MenuTypeId")]
        public MenuType MenuType { get; set; }
                                          
        public List<Item> Items { get; set; }
        public bool IsDeleted { get; set; }
    }
}
