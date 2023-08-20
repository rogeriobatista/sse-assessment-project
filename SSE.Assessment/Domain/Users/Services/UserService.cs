using SSE.Assessment.Domain.Users.Dtos;
using SSE.Assessment.Domain.Users.Interfaces;
using System.Text.Json;

namespace SSE.Assessment.Domain.Users.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UserService(IHttpClientFactory httpClientFactory) =>
        _httpClientFactory = httpClientFactory;

        public async Task<UserResponseDto> Get()
        {
            var httpClient = _httpClientFactory.CreateClient("Users");

            var response = await httpClient.GetAsync("users");

            if ( response.IsSuccessStatusCode )
            {
                using var contentStream = await response.Content.ReadAsStreamAsync();

                return new UserResponseDto
                {
                    StatusCode = response.StatusCode,
                    Content = await JsonSerializer.DeserializeAsync<List<UserDto>>(contentStream)
                };
            }

            return new UserResponseDto
            {
                StatusCode = response.StatusCode,
            };
        }
    }
}
