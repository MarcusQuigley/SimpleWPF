using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SimpleWPF.Model
{
    public class ProcessThreadInfo : ModelBase
    {
        private int _id;
        private DateTime _startTime;
        private int _currentPriority;
        private ThreadState _threadState;
        private ThreadWaitReason _waitReason;
        private ThreadPriorityLevel _priorityLevel;
        private DateTime _totalProcessorTime;
       
         public int Id
        {
            get { return _id; }
        }
        public DateTime StartTime
        {
            get { return _startTime; }
        }
        public DateTime TotalProcessorTime
        {
            get { return _totalProcessorTime; }
        }

        public ThreadWaitReason WaitReason
        {
            get { return _waitReason; }
         }

        public int CurrentPriority
        {
            get { return _currentPriority; }
            set
            {
                if (value != CurrentPriority)
                {
                    _currentPriority = value;
                    this.OnPropertyChanged("CurrentPriority");
                }
            }
        }

        public ThreadState ThreadState
        {
            get { return _threadState; }
            set
            {
                if (value != _threadState)
                {
                    _threadState = value;
                    this.OnPropertyChanged("ThreadState");
                }
            }
        }

        public ThreadPriorityLevel PriorityLevel
        {
            get { return _priorityLevel; }
            set
            {
                if (value != _priorityLevel)
                {
                    _priorityLevel = value;
                    this.OnPropertyChanged("PriorityLevel");
                }
            }
        }

    }
}
