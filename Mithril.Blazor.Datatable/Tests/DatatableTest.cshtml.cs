using Microsoft.AspNetCore.Blazor.Components;
using System.Collections.Generic;

namespace Mithril.Blazor.Datatable.Tests
{
    public class DatatableTestModel : BlazorComponent
    {
        public List<object> Items { get; set; }

        public DatatableTestModel()
        {
            Items = new List<object>();
        }
    }
}