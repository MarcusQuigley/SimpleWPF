 
namespace SimpleWPF.Data
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading;
    using System.ComponentModel;

    public delegate void ProcessesHandler(List<Process> processes);

    public class Processes
    {
        private TimeSpan sleepDuration;
        Thread workerThread;
        private bool _endProcess = false;
        public event ProcessesHandler ProcessList = delegate { };

        public bool EndProcess
        {
            get { return _endProcess; }
            set
            {
                _endProcess = value;
                if (value == true)
                {
                    workerThread.Join();
                    //      Console.WriteLine("Thread has ended");
                }
            }
        }

        public Processes(TimeSpan duration)
        {
            sleepDuration = duration;

            workerThread = new Thread(DoWork);
            workerThread.Start();
        }

        public Processes(double durationInMilliseconds)
            : this(TimeSpan.FromMilliseconds(durationInMilliseconds)) { }


        protected void RaiseProcesses(List<Process> processes)
        {
            ProcessesHandler handler = ProcessList;
            if (handler != null)
            {
                handler(processes);
            }
        }


        void DoWork()
        {
            while (EndProcess == false)
            {
                var list = Process.GetProcesses().ToList();
                RaiseProcesses(list);
                Thread.Sleep(sleepDuration);
            }

            //  Console.WriteLine("Ending thread");
        }

        //~Processes()
        //{
        //    Console.WriteLine("IN finalize of GetProcess");
        // }
    }
}
