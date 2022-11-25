using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public int Amount { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
