
using System.ComponentModel.DataAnnotations;

namespace FirmaMF.DataAccess.Entities
{
    public class Tool : EntityBase
    {
        [Required]
        public int CompanyId { get; set; }
        [Required]
        [MaxLength(100)]
        public string ToolName { get; set; }
        [MaxLength(200)]
        public string  ToolDescription { get; set; }
        [Required]
        public int DateOfPurchase { get; set; }
        [Required]
        public int Guarantee { get; set; }
    }
}
