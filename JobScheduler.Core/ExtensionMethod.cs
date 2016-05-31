using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Core
{
    public static class ExtensionMethod
    {
        #region List
        public static List<T> AddIfNotExist<T>(this List<T> list, T entry)
        {
            if (!list.Contains(entry)) list.Add(entry);
            return list;
        }
        #endregion
    }
}
