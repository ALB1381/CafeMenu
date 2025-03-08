using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }


        [Column(TypeName = "nvarchar(60)")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(60)")]
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
    }
}
