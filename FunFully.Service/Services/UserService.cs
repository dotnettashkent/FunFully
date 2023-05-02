using AutoMapper;
using FunFully.Data.IRepositories;
using FunFully.Domain.Entities.Users;
using FunFully.Service.DTOs.Users;
using FunFully.Service.Exceptions;
using FunFully.Service.Interfaces;

namespace FunFully.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        private readonly IRepository<User> repository;

        public UserService(IMapper mapper,
            IRepository<User> repository)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        public async ValueTask<UserResultDto> CreateAsync(UserCreationDto dto)
        {
            var user = mapper.Map<User>(dto);

            user = await repository.InsertAsync(user);

            return mapper.Map<UserResultDto>(user);
        }

        public async ValueTask<bool> DeleteAsync(long id)
        {
            var user = await repository.GetAsync(id);

            if (user == null)
            {
                return false;
                throw new FunFullyException(404, "User not found...");
            }

            return await repository.DeleteAsync(user);
        }

        public async ValueTask<IEnumerable<UserResultDto>> GetAllAsync()
        {
            var users = await repository.GetAllAsync();

            return mapper.Map<IEnumerable<UserResultDto>>(users);
        }

        public async ValueTask<UserResultDto> GetByIdAsync(long id)
        {
            var user = await repository.GetAsync(id);
            if (user == null)
                throw new FunFullyException(404, "User not found...");

            return mapper.Map<UserResultDto>(user);
        }



        public async ValueTask<UserResultDto> UpdateAsync(UserUpdateDto dto)
        {
            var user = await repository.GetAsync(dto.Id);

            if (user == null)
            {
                return null;
                throw new FunFullyException(404, "User not found...");
            }

            mapper.Map(dto, user);

            user = await repository.UpdateAsync(user);

            return mapper.Map<UserResultDto>(user);
        }
    }
}
