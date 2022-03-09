using System.Text.Json.Serialization;

namespace TestingGenericComponents.Models;

public class TodoModel
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("userId")]
    public long UserId { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("completed")]
    public bool Completed { get; set; }
}
