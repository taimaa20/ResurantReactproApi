using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ResurantReactpro.Models
{
    public class OrderMasters
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderMasterId { get; set; }
        public int OrderNumber { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public int PMethode { get; set; }
        public double GTotal { get; set; }
        public ICollection<OrderDetails> _OrderDetails { get; set; }
        public Customers customers { get; set; }
    }
}
