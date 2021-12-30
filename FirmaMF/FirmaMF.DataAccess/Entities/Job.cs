using System.ComponentModel.DataAnnotations;

namespace FirmaMF.DataAccess.Entities
{
    public class Job : EntityBase
    {
        [Required]
        public int IdFirma { get; set; }
        [Required]
        public int IdKlient { get; set; }
        [Required]
        public int IdOrderAddress { get; set; }
        public int Status { get; set; }
        [Required]
        [MaxLength(100)]
        public string Theme { get; set; }
        [MaxLength(350)]
        public string Description { get; set; }
        public int DateAdded { get; set; }
        public int DateStart { get; set; }
        public int DateEnd { get; set; }
        public decimal Price { get; set; }


    }
}
