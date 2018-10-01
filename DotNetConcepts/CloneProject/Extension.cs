using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneProject
{
    public static class Extension
    {
        public static string ToTraceDateTime(this DateTime datetime)
        {
            return datetime.ToString("dd-MM-yyyy HH:mm:ss");
        }

        public static int[] ToClone(this int[] intArray)
        {
            return (int[])intArray.Clone();
        }

        public static IList<T> ToClone<T>(this IList<T> listtoClone) where T:ICloneable
        {
            return listtoClone.Select(item => (T)item.Clone()).ToList();
        }



    }
}
