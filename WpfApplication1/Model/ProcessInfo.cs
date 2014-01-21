using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1.Model
{
   public class ProcessInfo
    {
       public string ProcessName { get; set; }
       public int ProcessID { get; set; }
       public int PrivateMemorySize { get; set; }
       public DateTime StartTime { get; set; }
       public ProcessPriority Priority{get;set;}
       public IList<ProcessThreadInfo> Threads { get; set; }
    }

   

  

}
