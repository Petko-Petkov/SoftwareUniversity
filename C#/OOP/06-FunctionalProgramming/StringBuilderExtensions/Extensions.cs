namespace StringBuilderExtensions
{
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public static class Extensions
    {
        #region Methods

        public static StringBuilder Substring(this StringBuilder strBuilder, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();
            string str = strBuilder.ToString();

            if ((startIndex + length) > str.Length)
            {
                throw new IndexOutOfRangeException("Index is out of the allowed range");
            }

            for (int i = startIndex; i < startIndex + length; i++)
			{
                result.Append(str[i]);
			}

            return result;
        }

        public static StringBuilder RemoveText(this StringBuilder strbuilder, string text)
        {
            strbuilder.Replace(text, string.Empty);
            return strbuilder;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder strBuilder, IEnumerable<T> items)
        {
            foreach (var t in items)
            {
                strBuilder.Append(t.ToString());
            }

            return strBuilder;
        }

        #endregion
    }
}
