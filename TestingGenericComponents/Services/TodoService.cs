using System.Net.Http.Json;

namespace TestingGenericComponents.Services;

public class TodoService : ITodoService
{
    private readonly HttpClient _httpClient;

    public TodoService(HttpClient httpClient) => _httpClient = httpClient;

    public async Task<TodoModel[]> GetTodos() =>
        await _httpClient.GetFromJsonAsync<TodoModel[]>("todos") ?? Array.Empty<TodoModel>();
}
