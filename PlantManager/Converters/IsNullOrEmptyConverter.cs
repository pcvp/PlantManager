using System;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlantManager.Converters
{
    public class IsNullOrEmptyConverter : IValueConverter, IMarkupExtension
    {

        public bool Invert { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string)
            {
                var text = (string)value;
                return Invert ? !string.IsNullOrEmpty(text) : string.IsNullOrEmpty(text);
            }

            if (value is int || value is decimal)
            {
                var number = (decimal)value;
                return Invert ? !(number > 0) : number > 0;
            }

            return Invert ? value != null : value == null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
