using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictantusCore
{
    public class User : Identify
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public double Statistic { get; set; }
    }
}
