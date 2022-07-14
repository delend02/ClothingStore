using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СlothingStore.API.Models.DTO
{
    public class UserDTO
    {
        public ulong ID { get; set; }
        public string Nickname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public decimal Cash { get; set; }
    }
}
