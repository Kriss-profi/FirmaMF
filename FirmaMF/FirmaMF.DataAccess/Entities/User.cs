using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaMF.DataAccess.Entities
{
    public class User : EntityBase
    {
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(80)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Password { get; set; }
        public int  DateCreate { get; set; }
        public int DateExpiration { get; set; }      //Data Ważności
        public int DateLock { get; set; }      //Data Blokady Problem z użyciem: TimestampAttribute
        public bool Status { get; set; }

    }
}
