using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Accounting.Models
{
    public class WidgetItem
    {
        public System.Windows.Forms.Control Widget { get; set; }
        public string DisplayText { get; set; }

        public override string ToString() => DisplayText;
    }
}
