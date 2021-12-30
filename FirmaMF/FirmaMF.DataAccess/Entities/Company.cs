using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirmaMF.DataAccess.Entities
{
    public class Company : EntityBase
    {
        // Pole Id przeniesione do EntityBase
        [Required]
        [MaxLength(100)]
        public string CompanyName { get; set; }
        public bool Status { get; set; }
        [MaxLength(11)]
        public string Nip { get; set; }
        [MaxLength(11)]
        public string UsdId { get; set; }
        public List<Address> Address { get; set; }
    }
}
