using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1.Model
{
    public class ProcessThreadInfo
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public int CurrentPriority { get; set; }
    }
}
