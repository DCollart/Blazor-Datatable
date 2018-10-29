using Microsoft.AspNetCore.Blazor.Components;
using System.Collections.Generic;

namespace Mithril.Blazor.Datatable.Components
{
    public class DatatableModel<TItem> : BlazorComponent
    {
        [Parameter]
        protected IReadOnlyList<TItem> Items { get; set; }
    }
}