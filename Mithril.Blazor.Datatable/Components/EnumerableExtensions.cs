using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mithril.Blazor.Datatable.Components
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TItem> Page<TItem>(this IEnumerable<TItem> items, int pageSize, int pageNumber)
        {
            return items.Skip((pageNumber-1)*pageSize).Take(pageSize);
        }
    }
}
