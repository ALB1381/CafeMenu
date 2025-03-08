using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.Customer
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }


        [DataType("nvarchar(60)")]
        public string CustomerName { get; set; }

        [DataType("nvarchar(20)")]
        public string Sex { get; set; }

        [DataType("nvarchar(40)")]
        public string Area { get; set; }

        public List<Order.Order> Orders { get; set; }
        public bool IsDeleted { get; set; }

    }
}
