using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ExtensionsForIEnumerable
{
    public static class IEnumerableExtensions<T>
    {
        public static dynamic Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = 0;
            var newCollection = collection.ToList();
            
            for (int i = 0; i < newCollection.Count; i++)
            {
                sum += newCollection[i];
            }

            return sum;
        }

        public static dynamic Min(this IEnumerable<T> collection)
        {
            var newCollection = collection.ToList();

            return newCollection.Min();
        }

        public static dynamic Max(this IEnumerable<T> collection)
        {
            var newCollection = collection.ToList();

            return newCollection.Max();
        }

        public static dynamic Avarage(this IEnumerable<T> collection)
        {
            var newCollection = collection.ToList();
            dynamic sum = 0;

            for (int i = 0; i < newCollection.Count; i++)
            {
                sum += newCollection[i];
            }

            return sum / newCollection.Count;
        }
    }
}
