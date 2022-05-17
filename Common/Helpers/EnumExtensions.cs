using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SudokuInterViewCaseStudy.Common.Helpers
{
    public static class EnumExtentions
    {
        public static int GetIntValue(this Enum e)
        {
            return e.GetValue<Int32>();
        }

        public static T GetValue<T>(this Enum e) where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            return (T)(object)e;
        }
        public static IEnumerable<TEnum> EnumValues<TEnum>() where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            var enumType = typeof(TEnum);

            // Optional runtime check for completeness    
            if (!enumType.IsEnum)
            {
                throw new ArgumentException();
            }

            return Enum.GetValues(enumType).Cast<TEnum>();
        }
        public static int ToInt(this Enum enumValue)
        {
            return (int)((object)enumValue);
        }
        public static T ParseEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

    }
}
