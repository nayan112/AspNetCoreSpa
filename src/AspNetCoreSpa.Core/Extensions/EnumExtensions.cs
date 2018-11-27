using System;
using System.Collections.Generic;

namespace MyCommunity.Core
{
    public static class EnumExtensions
    {
        public static Dictionary<int, string> ToDict(this Enum theEnum)
        {
            var enumDict = new Dictionary<int, string>();
            foreach (int enumValue in Enum.GetValues(theEnum.GetType()))
            {
                enumDict.Add(enumValue, enumValue.ToString());
            }

            return enumDict;
        }
    }
}