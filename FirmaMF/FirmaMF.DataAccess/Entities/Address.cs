using System.ComponentModel.DataAnnotations;

namespace FirmaMF.DataAccess.Entities
{
    public class Address : EntityBase
    {
        [Required]
        [MaxLength(11)]
        public int ClientId { get; set; }
        
        [MaxLength(6)]
        public string Code { get; set; }
        
        [MaxLength(30)]
        public string City { get; set; }

        [MaxLength(50)]
        public string Street { get; set; }

        [MaxLength(10)]
        public string Number { get; set; }
    }
}
