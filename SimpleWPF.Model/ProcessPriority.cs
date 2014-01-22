using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWPF.Model
{
    public enum ProcessPriority
    {
        Normal = 32,
        Idle = 64,
        High = 128,
        RealTime = 256,
        BelowNormal = 16384,
        AboveNormal = 32768,
    }
}
