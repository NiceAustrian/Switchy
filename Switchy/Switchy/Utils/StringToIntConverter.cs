using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace Switchy.Utils;

public class StringToIntConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is int intValue)
            return intValue.ToString();

        return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (int.TryParse(value as string, out int result))
            return result;

        return DependencyProperty.UnsetValue;
    }
}
