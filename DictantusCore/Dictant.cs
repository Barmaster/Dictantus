using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictantusCore
{
    public class Dictant : Identify
    {
        public string Text { get; set; }
        public string Header { get; set; }
        public string StudentText { get; set; }
    }
}
