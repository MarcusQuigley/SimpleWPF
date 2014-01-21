using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApplication1.Data;

namespace WpfApplication1.ViewModels
{
  public static class ViewModelLocator
    {
      private static ProcessesViewModel _processViewModel;

      public static ProcessesViewModel ProcessesViewModel
      {
          get
          { 
            return _processViewModel ??
              ( _processViewModel = new ProcessesViewModel(
                  new DataProvider()));
          }
      }
    }
}
