using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02.Delegates
{
    public static class Extensions
    {
            public static List<T> WhereCustom<T>(this List<T> products, Func<T, bool> func) where T : class, new()
            {
                List<T> result = new List<T>();



                foreach (var product in products)
                {
                    if (func.Invoke(product))
                    {
                        result.Add(product);
                    }
                }
                return result;
            }
        

    }
}
