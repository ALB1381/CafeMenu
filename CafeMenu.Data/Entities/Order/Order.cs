using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Order
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        public int OrderSum { get; set; } 

        public bool IsPayed { get; set; }

        public DateTime OrderDate { get; set; }

        public string? Description { get; set; }

        public int CustomerId { get; set; }

        [Column(TypeName = "tinyint")]
        public int? TableId { get; set; }

        [ForeignKey("TableId")]
        public Table Table { get; set; }
        public List<SubOrder> SubOrders { get; set; }

        [ForeignKey("CustomerId")]
        public Customer.Customer Customer { get; set; }
        public bool IsDeleted { get; set; }


    }
}
