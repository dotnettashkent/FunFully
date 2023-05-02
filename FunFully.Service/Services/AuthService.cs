using FunFully.Service.Interfaces;
using Microsoft.Extensions.Configuration;

namespace FunFully.Service.Services
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration configuration;

        public AuthService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public ValueTask<string> GenerateTokeAsync(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
