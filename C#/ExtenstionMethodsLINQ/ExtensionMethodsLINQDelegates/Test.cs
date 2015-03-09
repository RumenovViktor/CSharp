using ExtensionMethodsLINQDelegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Test
{
    static void Main()
    {
        StringBuilder st = new StringBuilder();
        st.Append("sdasfsfsdfdsgrehgerg");

        Console.WriteLine(st.Substring(1, 2));

        Console.WriteLine(st);
    }
}