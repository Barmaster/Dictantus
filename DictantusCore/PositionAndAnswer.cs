using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictantusCore
{
    public class PositionAndAnswer : Identify
    {
        public int Position { get; set; }
        public string Answer { get; set; }
        public int ID_dictant { get; set; }
    }
}
