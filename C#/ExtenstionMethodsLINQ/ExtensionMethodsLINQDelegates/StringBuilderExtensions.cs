using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsLINQDelegates
{
    public static class StringBuilderExtensions 
    {
        public static StringBuilder Substring(this StringBuilder expression, int index, int length)
        {
            if (index < 0 || index > expression.Length || length >= expression.Length || length < 0 )
            {
                throw new IndexOutOfRangeException("Index was outside the boundries of the array.");
            }

            StringBuilder builder = new StringBuilder();

            for (int i = index; i <= length; i++)
            {
                builder.Append(expression[i]);
            }

            return builder;
        }
    }
}
