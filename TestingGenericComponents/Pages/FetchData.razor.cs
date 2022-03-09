namespace TestingGenericComponents.Pages;

public partial class FetchData
{
    private TodoModel[]? todos;

    protected override async Task OnInitializedAsync() => todos = await TodoService.GetTodos();
}
