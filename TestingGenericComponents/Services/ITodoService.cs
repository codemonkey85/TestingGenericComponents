namespace TestingGenericComponents.Services;

public interface ITodoService
{
    Task<TodoModel[]> GetTodos();
}
