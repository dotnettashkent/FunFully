using FunFully.Service.DTOs.Moneys;

namespace FunFully.Service.Interfaces
{
    public interface IMoneyService
    {
        ValueTask<AddMoneyResultDto> AddMoneyAsync(AddMoneyCreationDto dto);
        ValueTask<GetMoneyResultDto> GetMoneyAsync(GetMoneyCreationDto dto, long id);
        ValueTask<bool> DeleteAddMoneyAsync(long id);
        ValueTask<bool> DeleteGetMoneyAsync(long id);
    }
}
