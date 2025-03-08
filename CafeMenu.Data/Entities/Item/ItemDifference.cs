using CafeMenu.Data.Entities.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Item
{
    public class ItemDifference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DifferenceId { get; set; }

        [Column(TypeName = "nvarchar(60)")]
        public string DifferenceTitle { get; set; }

        public int ItemDifferncePrice { get; set; }

        public int ItemID { get; set; }

        [ForeignKey("ItemID")]
        public Item Item { get; set; }

        public List<SubOrder> SubOrders { get; set; }
        public bool IsDeleted { get; set; }

    }
}
