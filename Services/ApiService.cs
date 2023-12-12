using Microsoft.Extensions.Logging;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using TreinamentoWPF;
using TreinamentoWPF.Models.Evoliz;

namespace EvolizAPI.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;
        private string accessToken;
        private DateTime accessTokenExpiration;


        private readonly ILogger<ApiService> _logger;

        public ApiService(ILogger<ApiService> logger)
        {
            _logger = logger;
        }



        public ApiService()
        {
            HttpClient httpClient = new();
            ILogger<ApiService> logger;
            _httpClient = httpClient;

        }

        public async Task<string> GetAccessToken()
        {
            if (string.IsNullOrEmpty(accessToken) || DateTime.UtcNow >= accessTokenExpiration)
            {
                var loginUrl = "https://www.evoliz.io/api/login";
                var loginRequest = new
                {
                    public_key = "6578ac3fbf402169536128DErtxWpB14",
                    secret_key = "48d26d080dd8b6b682e8a93d13ea1c48yz7PgMBrlD8CkotIbu"
                };

                var json = JsonSerializer.Serialize(loginRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(loginUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    var loginResponseObj = JsonSerializer.Deserialize<LoginResponse>(responseJson);

                    accessToken = loginResponseObj.access_token;
                    accessTokenExpiration = loginResponseObj.expires_at;
                    LoggedUser.Token = accessToken;
                    LoggedUser.AccessTokenExpiration = accessTokenExpiration;
                    return loginResponseObj.access_token;
                }

            }

            return accessToken;
        }

        public async Task<ArticlesApiResponse> GetArticles(int page)
        {
            try
            {
                string accessToken = await GetAccessToken();

                // URL para buscar os artigos com paginação
                string url = $"https://evoliz.io/api/v1/companies/80333-101556/articles?page={page}";


                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {LoggedUser.Token}");
                // Chamada à API para obter os dados dos artigos
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    string responseJson = await response.Content.ReadAsStringAsync();


                    // Salvar o JSON em um arquivo
                    await DebugSaveResponseJsonToFile(responseJson, "c:/Dev/Debug/Evoliz/");


                    // Configurações para desserialização do JSON
                    var options = new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase // Define a conversão para camelCase
                    };

                    // Deserializar a resposta da API para o objeto ArticlesApiResponse
                    ArticlesApiResponse articlesApiResponse = JsonSerializer.Deserialize<ArticlesApiResponse>(responseJson, options);

                    return articlesApiResponse;
                }


                return null;
            }
            catch (HttpRequestException ex)
            {
                //_logger.LogError($"Erro na requisição HTTP: {ex.Message}");
                throw;
            }
            catch (JsonException ex)
            {
                //_logger.LogError($"Erro na desserialização JSON: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                //_logger.LogError($"Erro inesperado: {ex.Message}");
                throw;
            }
        }



        public async Task DebugSaveResponseJsonToFile(string responseJson, string filePath)
        {
            try
            {
                // Salvar como JSON
                await File.WriteAllTextAsync(filePath + "evoliz.json", responseJson);

                // salvar como TXT
                // await File.WriteAllTextAsync(filePath + ".txt", responseJson);
            }
            catch (Exception ex)
            {
                //_logger.LogError($"Erro ao salvar o arquivo: {ex.Message}");
                throw;
            }
        }
    }


    public class LoginResponse
    {
        public string access_token { get; set; }
        public DateTime expires_at { get; set; }
        public string[] scopes { get; set; }
    }

}
