using Microsoft.AspNetCore.Blazor.Components;
using System;

namespace Mithril.Blazor.Datatable.Components
{
    public class PaginationModel : BlazorComponent
    {
        [Parameter]
        protected int PageSize { get; set; }

        [Parameter]
        protected int PageNumber { get; set; }

        [Parameter]
        protected int TotalItems { get; set; }

        [Parameter]
        protected Action<int> OnPageNumberChanged { get; set; }

        protected int MaxPageNumber => (int)Math.Ceiling(((double)TotalItems) / PageSize);

        protected void Next()
        {
            if (PageNumber < MaxPageNumber)
            {
                GoToPage(PageNumber+1);
            }
        }

        protected void Previous()
        {
            if (PageNumber > 1)
            {
                GoToPage(PageNumber - 1);
            }
        }

        protected void GoToPage(int pageNumber)
        {
            PageNumber = pageNumber;
            OnPageNumberChanged?.Invoke(pageNumber);
        }
    }
}