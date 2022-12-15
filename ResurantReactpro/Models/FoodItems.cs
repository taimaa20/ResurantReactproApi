using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResurantReactpro.Models
{
    public class FoodItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodItemId{ get; set; }
        public string FoodItemName { get; set; }
        public double Price { get; set; }
        public ICollection<OrderDetails> _OrderDetails { get; set; }
    }
}
