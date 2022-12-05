using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(70)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [Range(1, int.MaxValue, ErrorMessage = "Amount should be greater then 0.")]
        public int Amount { get; set; }

        [Range(1, int.MaxValue,ErrorMessage = "Please select a category.")]    
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public string? CategoryTitleWithIcon
        {
            get
            {
                return Category?.Title + " " + Category?.Icon ?? string.Empty;
            }
        }

        public string? FormattedrAmount
        {
            get
            {
                return ((Category == null || Category.Type == "Expense") ? "- " :"+ ") + Amount.ToString("C0");
            }
        }
    }
}
