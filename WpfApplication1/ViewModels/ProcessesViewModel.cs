using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApplication1.Model;

using WpfApplication1.Data;
namespace WpfApplication1.ViewModels
{
    public class ProcessesViewModel
    {
        readonly IDataProvider _dataProvider;
        IList<ProcessInfo> _processes;

        public IList<ProcessInfo> Processes
        {
            get
            {
                return _processes
                ?? (_processes = GetProcesses());
            }
        }

        private IList<ProcessInfo> GetProcesses()
        {
            return _dataProvider.GetProcesses();
        }

        public ProcessesViewModel(IDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
        }

    }
}
