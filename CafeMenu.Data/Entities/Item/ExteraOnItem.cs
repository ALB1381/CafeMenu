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
    public class ExteraOnItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExtraId { get; set; }

        [Column(TypeName = "nvarchar(60)")]
        public string ExteraTitle { get; set; }

        public int ExteraOnItemPrice { get; set; }

        [Column(TypeName = "nvarchar(70)")]
        public string? ExteraOnItemDecription { get; set; }

        public List<ItemExteraOnItemConnection> itemExteraOnItemConnections { get; set; }
        public List<SubOrderExtraOnItemConnection> SubOrderExtraOnItemConnection { get; set; }
        public bool IsDeleted { get; set; }

    }
}
