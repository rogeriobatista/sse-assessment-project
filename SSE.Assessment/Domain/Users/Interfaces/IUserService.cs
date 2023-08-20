using SSE.Assessment.Domain.Users.Dtos;

namespace SSE.Assessment.Domain.Users.Interfaces
{
    public interface IUserService
    {
        Task<UserResponseDto> Get();
    }
}
