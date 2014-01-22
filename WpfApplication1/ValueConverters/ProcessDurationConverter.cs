using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace WpfApplication1.ValueConverters
{
    class ProcessDurationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if  (targetType !=typeof( String)) throw new ArgumentException("Target Type is not a string");

            DateTime threadStarttime = DateTime.Parse(value.ToString());
            var diffInMins = (DateTime.Now - threadStarttime).TotalMinutes;
            return "Minutes alive = " + diffInMins;
           
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
