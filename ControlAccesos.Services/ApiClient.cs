using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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
        AddJwtHeader(); // Ensure token is applied if needed
        Debug.WriteLine($"GET Request: {path}");
        Debug.WriteLine($"JWT Token: {_jwtToken}");

        HttpResponseMessage response = await _httpClient.GetAsync(path);

        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            Debug.WriteLine("Resource not found (404). Returning null.");
            return default;
        }

        if (!response.IsSuccessStatusCode)
        {
            Debug.WriteLine($"Request failed with status {response.StatusCode}");
            throw new HttpRequestException($"Request failed: {response.StatusCode}");
        }

        string json = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() }
        });
    }


    public async Task<TResponse?> PostAsync<TRequest, TResponse>(string path, TRequest data)
    {
        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() }
        });
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        Debug.WriteLine($"POST Request: {path}");
        Debug.WriteLine($"Request Body: {json}");

        HttpResponseMessage response = await _httpClient.PostAsync(path, content);
        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            Debug.WriteLine("Resource not found (404). Returning null.");
            return default;
        }

        if (!response.IsSuccessStatusCode)
        {
            Debug.WriteLine($"Request failed with status {response.StatusCode}");
            throw new HttpRequestException($"Request failed: {response.StatusCode}");
        }

        string responseBody = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<TResponse>(responseBody, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() }
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

    public async Task PostAsync<TRequest>(string path, TRequest data)
    {
        var options = new JsonSerializerOptions
        {
            Converters = { new JsonStringEnumConverter() }
        };
        string json = JsonSerializer.Serialize(data, options);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _httpClient.PostAsync(path, content);
        Debug.WriteLine(json);
        if (!response.IsSuccessStatusCode)
        {
            string errorContent = await response.Content.ReadAsStringAsync();

            using var errorDoc = JsonDocument.Parse(errorContent);
            if (errorDoc.RootElement.TryGetProperty("errors", out JsonElement errors))
            {
                var messages = new List<string>();

                foreach (JsonProperty prop in errors.EnumerateObject())
                {
                    foreach (JsonElement message in prop.Value.EnumerateArray())
                    {
                        messages.Add(message.GetString());
                    }
                }

                string combinedErrors = string.Join(" ", messages); // Or use "\n" for line breaks

                throw new HttpRequestException(combinedErrors);
            }
            else
            {
                throw new HttpRequestException("Ocurrió un error inesperado.");
            }
        }
    }


    public async Task<TResponse?> PostWithQueryAsync<TResponse>(
        string path,
        Dictionary<string, string> queryParams
    )
    {
        return await PostWithQueryAsync<object, TResponse>(path, queryParams, null);
    }

    public async Task<TResponse?> PutAsync<TRequest, TResponse>(string path, TRequest data)
    {
        string json = JsonSerializer.Serialize(data);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _httpClient.PutAsync(path, content);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<TResponse>(responseBody, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
    }

    public async Task<string> DeleteAsync(string path)
    {
        HttpResponseMessage response = await _httpClient.DeleteAsync(path);

        if (!response.IsSuccessStatusCode)
        {
            string error = await response.Content.ReadAsStringAsync();
            throw new HttpRequestException($"DELETE failed: {response.StatusCode}\n{error}");
        }
        return await response.Content.ReadAsStringAsync();
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
