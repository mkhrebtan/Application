using System.Net.Http.Json;
using Application.Assistant;

namespace Infrastructure.Assistant;

internal sealed class GroqAssistant(IHttpClientFactory httpClientFactory) : IAiAssistant
{
    public async Task<string> GetResponseAsync(Prompt prompt, CancellationToken cancellationToken)
    {
        using var client = httpClientFactory.CreateClient("GroqCLient");
        var requestBody = new
        {
            model = "llama-3.1-8b-instant",
            messages = new[]
            {
                new
                {
                    role = "system",
                    content =
                        "You are a helpful assistant that provides accurate and concise information based on the user's query.",
                },
                new
                {
                    role = "user",
                    content = prompt.Query,
                },
            },
        };

        var response = await client.PostAsJsonAsync("chat/completions", requestBody, cancellationToken);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadFromJsonAsync<GroqResponse>(cancellationToken);
        return responseBody?.Choices?.FirstOrDefault()?.Message?.Content ?? string.Empty;
    }
}