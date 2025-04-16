using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerSample
{
    public class ControlModel
    {
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }
        public string Name { get; set; } = string.Empty;
        public Brush? Color { get; set; }
    }
}
