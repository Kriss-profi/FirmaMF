using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirmaMF.DataAccess.Entities
{
    public class Client : EntityBase
    {
        [Required]
        public int CompanyId { get; set; }
        
        [MaxLength(150)]
        public string CompanyName { get; set; }
        [MaxLength(70)]
        public string Vorname { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public List<Address> Address { get; set; }

    }
}
