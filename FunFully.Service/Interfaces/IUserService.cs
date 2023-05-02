using FunFully.Service.DTOs.Users;

namespace FunFully.Service.Interfaces
{
    public interface IUserService
    {
        ValueTask<UserResultDto> CreateAsync(UserCreationDto dto);
        ValueTask<UserResultDto> UpdateAsync(UserUpdateDto dto);
        ValueTask<bool> DeleteAsync(long id);
        ValueTask<IEnumerable<UserResultDto>> GetAllAsync();
        ValueTask<UserResultDto> GetByIdAsync(long id);
    }
}
