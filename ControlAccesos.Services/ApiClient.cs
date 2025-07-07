using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class ApiClient
{
    private readonly HttpClient _httpClient;
    private string? _jwtToken { get; set; }

    public ApiClient(string baseUrl)
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(baseUrl)
        };
    }

    public ApiClient(string baseUrl, string _jwtToken)
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri(baseUrl)
        };
        this._jwtToken = _jwtToken;
        AddJwtHeader();
    }

    private void AddJwtHeader()
    {
        _httpClient.DefaultRequestHeaders.Remove("Authorization");

        if (!string.IsNullOrEmpty(_jwtToken))
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_jwtToken}");
        }
    }

    public async Task<T?> GetAsync<T>(string path)
    {
        Debug.WriteLine($"GET Request: {path}");
        Debug.WriteLine($"JWT Token: {_jwtToken}");
        HttpResponseMessage response = await _httpClient.GetAsync(path);
        response.EnsureSuccessStatusCode();

        string json = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
    }

    public async Task<TResponse?> PostAsync<TRequest, TResponse>(string path, TRequest data)
    {
        string json = JsonSerializer.Serialize(data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _httpClient.PostAsync(path, content);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<TResponse>(responseBody, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
    }

    public async Task<TResponse?> PostWithQueryAsync<TRequest, TResponse>(
        string path,
        Dictionary<string, string> queryParams,
        TRequest? body = default
    )
    {
        // Build query string
        string query = await new FormUrlEncodedContent(queryParams).ReadAsStringAsync();
        string urlWithQuery = $"{path}?{query}";

        HttpContent? content = null;

        if (body != null)
        {
            string json = JsonSerializer.Serialize(body);
            content = new StringContent(json, Encoding.UTF8, "application/json");
        }

        HttpResponseMessage response = await _httpClient.PostAsync(urlWithQuery, content);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<TResponse>(responseBody, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
    }

    // Optional: Overload for PostWithQueryAsync with no body
    public async Task<TResponse?> PostWithQueryAsync<TResponse>(
        string path,
        Dictionary<string, string> queryParams
    )
    {
        return await PostWithQueryAsync<object, TResponse>(path, queryParams, null);
    }

    public static string BuildQueryString(Dictionary<string, string> parameters)
    {
        if(parameters == null || parameters.Count == 0)
        {
            return string.Empty;
        }
        return string.Join("&", parameters.Select(kvp =>
            $"{Uri.EscapeDataString(kvp.Key)}={Uri.EscapeDataString(kvp.Value)}"));
    }

}
