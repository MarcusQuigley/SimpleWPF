﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using WpfApplication1.Model;
using Diag = System.Diagnostics;

namespace WpfApplication1.Data
{
    public interface IDataProvider
    {
        IList<ProcessInfo> GetProcesses();
    }

    class DataProvider : IDataProvider
    {

        public IList<ProcessInfo> GetProcesses()
        {
            var list = System.Diagnostics.Process.GetProcesses().Select(p => GetProcessInfo(p));
            
            return list.ToList();
        }

        private ProcessInfo GetProcessInfo(Diag.Process process)
        {
            if (process == null) throw new ArgumentNullException("process");

            return new ProcessInfo()
          {
              ProcessID = process.Id,
              ProcessName = process.ProcessName,
              StartTime = process.StartTime,
              PrivateMemorySize = process.PrivateMemorySize,
              Priority = GetProcessPriority(process.PriorityClass),
              Threads = GetThreads(process.Threads)
          };

        }

        IList<ProcessThreadInfo> GetThreads(Diag.ProcessThreadCollection threads)
        {
            var threadList = threads.OfType<Diag.ProcessThread>().Select(p => GetProcessThreadInfo(p));

            return threadList.ToList();
        }

        ProcessThreadInfo GetProcessThreadInfo(Diag.ProcessThread thread)
        {
            if (thread == null) throw new ArgumentNullException("thread");

            return new ProcessThreadInfo
            {
                Id = thread.Id,
                CurrentPriority = thread.CurrentPriority,
                StartTime = thread.StartTime
            };
        }

        private ProcessPriority GetProcessPriority(Diag.ProcessPriorityClass priorityClass)
        {
            if (priorityClass == null) throw new ArgumentNullException("priorityClass");


            switch (priorityClass)
            {
                case Diag.ProcessPriorityClass.AboveNormal:
                    return ProcessPriority.AboveNormal;
                case Diag.ProcessPriorityClass.BelowNormal:
                    return ProcessPriority.BelowNormal;
                case Diag.ProcessPriorityClass.High:
                    return ProcessPriority.High;
                case Diag.ProcessPriorityClass.Idle:
                    return ProcessPriority.Idle;
                case Diag.ProcessPriorityClass.RealTime:
                    return ProcessPriority.RealTime;

                default:
                    throw new InvalidOperationException("Priority class is unknown");
            }
        }
    }
}
