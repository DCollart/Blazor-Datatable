using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mithril.Blazor.Datatable.Components
{
    public class Column<TItem>
    {
        public Func<string> Name { get; set; }
        public Func<TItem, string> Content { get; set; }

        public Column(Func<string> name, Func<TItem, string> content)
        {
            Name = name;
            Content = content;
        }
    }
}
