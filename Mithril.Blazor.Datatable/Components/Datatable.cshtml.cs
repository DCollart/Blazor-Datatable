using Microsoft.AspNetCore.Blazor;
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

        [Parameter]
        protected Action<TItem> OnLineClick { get; set; }

        protected IEnumerable<TItem> CurrentPage => GetCurrentPage();

        protected string SearchCriteria { get; set; }

        protected IEnumerable<TItem> GetCurrentPage()
        {
            return GetFilteredItems().Page(PageSize, PageNumber);
        }

        protected IEnumerable<TItem> GetFilteredItems()
        {
            return string.IsNullOrEmpty(SearchCriteria) ?
            Items
            : Items.Where(i => Columns
                .Select(c => c.Content(i).ToString())
                .Any(c => c.IndexOf(SearchCriteria, StringComparison.OrdinalIgnoreCase) >= 0));      
        }

        protected void OnPageNumberChanged(int pageNumber)
        {
            PageNumber = pageNumber;
            this.StateHasChanged();
        }

        protected void OnSearchCriteraChange(UIChangeEventArgs changeEvent)
        {
            if (changeEvent.Value.ToString() != SearchCriteria)
            {
                SearchCriteria = changeEvent.Value.ToString();
                PageNumber = 1;
            }
        }
    }
}