using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWPF.Model
{
    public class ProcessInfo : ModelBase
    {
        private string _name;
        private int _id;
        private int _memSize;
        private int _handlesUsed;
        private DateTime _startTime;
        private TimeSpan _totalProcessorTime;
        private string _mainWorkingTitle;
        private int _workingSet;
        private bool _hasExited;
        private ProcessPriority _priority;
        private IList<ProcessThreadInfo> _threads;

        public string ProcessName
        {
            get { return _name; }
        }

        public int ProcessID
        {
            get { return _id; }
        }

        public int PrivateMemorySize
        {
            get { return _memSize; }
        }

        public int HandlesUsed
        {
            get { return _handlesUsed; }
        }

        public DateTime StartTime
        {
            get { return _startTime; }
        }

        public TimeSpan TotalProcessorTime
        {
            get { return _totalProcessorTime; }
        }

        public int MemoryUsed
        {
            get { return _workingSet; }
        }

        public IList<ProcessThreadInfo> Threads
        {
            get { return _threads; }
        }

        public ProcessPriority Priority
        {
            get { return _priority; }
            set
            {
                if (value != _priority)
                {
                    _priority = value;
                    base.OnPropertyChanged("Priority");
                }
            }
        }

        public bool HasExited
        {
            get { return _hasExited; }
            set
            {
                if (value != _hasExited)
                {
                    _hasExited = value;
                    base.OnPropertyChanged("HasExited");
                }
            }
        }

        public string MainWorkingTitle
        {
            get { return _mainWorkingTitle; }
            set
            {
                if (value != _mainWorkingTitle)
                {
                    _mainWorkingTitle = value;
                    base.OnPropertyChanged("MainWorkingTitle");
                }
            }
        }
    }
}
