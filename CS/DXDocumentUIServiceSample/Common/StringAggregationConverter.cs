using System;
using System.Windows.Data;

namespace DXDocumentUIServiceSample.Common {
    public class StringAggregationConverter: IValueConverter {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return String.Format("{0}: {1}", parameter, value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
