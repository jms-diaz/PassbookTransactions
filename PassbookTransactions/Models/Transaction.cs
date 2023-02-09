using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassbookTransactions.Models
{
	public class Transaction
	{
		[Key]
		public int TransactionId { get; set; }

		[Column(TypeName ="nvarchar(12)")]
		[DisplayName("Account Number")]
		[Required(ErrorMessage ="This field is required")]
        [MaxLength(12, ErrorMessage ="Maximum of 12 characters")]
		public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This field is required")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is required")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(11, ErrorMessage = "Maximum of 11 characters")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString="{0:MMM dd yyyy}")]
		public DateTime DateModified { get; set; }


	}
}
