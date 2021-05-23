using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key] 
        public int Id { get; set; }
        [DisplayName("Expense Name")]
        [Required]
        public string ExpenseName { get; set; }
        [DisplayName("Amount")]
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        [Range((double)decimal.MinValue, (double)decimal.MaxValue, ErrorMessage = "Please enter valid amount")]
        public decimal ExpenseValue { get; set; }

    }
}