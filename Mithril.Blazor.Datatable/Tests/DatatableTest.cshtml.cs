using FizzWare.NBuilder;
using Microsoft.AspNetCore.Blazor.Components;
using Mithril.Blazor.Datatable.Components;
using System.Collections.Generic;
using System.Linq;

namespace Mithril.Blazor.Datatable.Tests
{
    public class DatatableTestModel : BlazorComponent
    {
        public List<Customer> Items { get; set; }
        public List<Column<Customer>> Columns { get; set; }


        public DatatableTestModel()
        {
            Items = Builder<Customer>
                .CreateListOfSize(33)
                .All()
                .With(c => c.FirstName = Faker.NameFaker.FirstName())
                .With(c => c.LastName = Faker.NameFaker.LastName())
                .Build()
                .ToList();

            Columns = new List<Column<Customer>>()
            {
                new Column<Customer>(() => nameof(Customer.FirstName), (item) => item.FirstName),
                new Column<Customer>(() => nameof(Customer.LastName), (item) => item.LastName),
                new Column<Customer>(() => "Fullname", (item) => $"{item.FirstName} {item.LastName}")
            };
        }
    }
}