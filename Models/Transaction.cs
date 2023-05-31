using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions_CRUD_.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required]
        [MaxLength(12, ErrorMessage = "Maximum of 12 characters")]
        public string? AccountNumber { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required]
        public string? BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required]
        public string? BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("IFSC Code")]
        [Required(ErrorMessage = "IFSC is Must")]
        [MaxLength(11, ErrorMessage = "Maximum of 11 characters")]
        public string? IFSCCode { get; set; }

        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime Date { get; set; }
    }
}
