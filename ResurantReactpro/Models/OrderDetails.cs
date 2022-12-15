using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResurantReactpro.Models
{
    public class OrderDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderDetailsId { get; set; }
        [ForeignKey("OrderMasterId")]

        public int OrderMasterId { get; set; }
        [ForeignKey("FoodItemId")]
        public int FoodItemId { get; set; }
        public double FoodItemPrice { get; set; }
        public int Quantity { get; set; }
        public FoodItems foodItems { get; set; }
        public OrderMasters orderMasters { get; set; }
    }
}
