using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Components;

namespace TestingGenericComponents.Components;

public partial class GenericTable<TItem>
{
    [Parameter]
    public RenderFragment? TableHeader { get; set; }

    [Parameter]
    public RenderFragment<TItem>? RowTemplate { get; set; }

    [Parameter, AllowNull]
    public IReadOnlyList<TItem> Items { get; set; }
}
