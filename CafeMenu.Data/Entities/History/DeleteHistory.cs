using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Data.Entities.History
{
    public class DeleteHistory
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(60)")]
        public string TableName { get; set; }

        public int DeletedRowId { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
