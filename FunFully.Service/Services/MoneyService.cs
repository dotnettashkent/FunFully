using AutoMapper;
using FunFully.Data.IRepositories;
using FunFully.Domain.Entities.Moneys;
using FunFully.Service.DTOs.Moneys;
using FunFully.Service.Interfaces;

namespace FunFully.Service.Services
{
    public class MoneyService : IMoneyService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Money> moneyRepository;

        public MoneyService(IMapper mapper, IRepository<Money> moneyRepository)
        {
            this.mapper = mapper;
            this.moneyRepository = moneyRepository;
        }

        public async ValueTask<AddMoneyResultDto> AddMoneyAsync(AddMoneyCreationDto dto)
        {
            var money = mapper.Map<Money>(dto);
            var result = await moneyRepository.InsertAsync(money);
            return mapper.Map<AddMoneyResultDto>(result);
        }

        public async ValueTask<bool> DeleteAddMoneyAsync(long id)
        {
            var money = await moneyRepository.GetAsync(id);
            if (money == null)
            {
                return false;
            }
            await moneyRepository.DeleteAsync(money);
            return true;
        }

        public async ValueTask<bool> DeleteGetMoneyAsync(long id)
        {
            var money = await moneyRepository.GetAsync(id);
            if (money == null)
            {
                return false;
            }
            await moneyRepository.DeleteAsync(money);
            return true;
        }

        public async ValueTask<GetMoneyResultDto> GetMoneyAsync(GetMoneyCreationDto dto, long id)
        {
            var money = await moneyRepository.GetAsync(id);
            if (money == null)
            {
                return null;
            }
            var result = mapper.Map<GetMoneyResultDto>(money);
            return result;
        }
    }
}
