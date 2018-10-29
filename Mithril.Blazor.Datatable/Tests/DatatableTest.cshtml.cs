using FizzWare.NBuilder;
using Microsoft.AspNetCore.Blazor.Components;
using System.Collections.Generic;
using System.Linq;

namespace Mithril.Blazor.Datatable.Tests
{
    public class DatatableTestModel : BlazorComponent
    {
        public List<Customer> Items { get; set; }

        public DatatableTestModel()
        {
            Items = Builder<Customer>
                .CreateListOfSize(33)
                .All()
                .With(c => c.FirstName = Faker.NameFaker.FirstName())
                .With(c => c.LastName = Faker.NameFaker.LastName())
                .Build()
                .ToList();
        }
    }
}