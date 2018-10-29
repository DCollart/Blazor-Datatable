using Microsoft.AspNetCore.Blazor.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mithril.Blazor.Datatable.Components
{
    public class DatatableModel<TItem> : BlazorComponent
    {
        [Parameter]
        protected IEnumerable<TItem> Items { get; set; }

        [Parameter]
        protected IEnumerable<Column<TItem>> Columns { get; set; }

        [Parameter]
        protected int PageSize { get; set; } = 10;

        [Parameter]
        protected int PageNumber { get; set; } = 1;

        protected int MaxPageNumber => (int)Math.Ceiling(((double)Items.Count()) / PageSize);

        protected IEnumerable<TItem> CurrentPage => Items.Page(PageSize, PageNumber);

        protected void Next()
        {
            if (PageNumber < MaxPageNumber)
            {
                PageNumber++;
            }
        }

        protected void Previous()
        {
            if (PageNumber > 1)
            {
                PageNumber--;
            }
        }
    }
}