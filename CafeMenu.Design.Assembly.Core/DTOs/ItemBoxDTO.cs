using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMenu.Design.Assembly.Core.DTOs
{
    public class ItemBoxDTO
    {
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string ItemIngredient { get; set; }
        public string ItemImage { get; set; }
        public List<Difference> Differences { get; set; }
        public List<Extera> Exteras { get; set; }
    }
    public class Difference
    {
        public int DifferenceId { get; set; }
        public string DifferenceTitle { get; set; }
        public int DifferencePrice { get; set; }
    }
    public class Extera
    {
        public int ExteraId { get; set; }
        public string ExteraTitle { get; set; }
        public string ExteraDescription { get; set; }
        public int ExteraPrice { get; set; }
    }
}
