namespace FunFully.Service.Interfaces
{
    public interface IAuthService
    {
        ValueTask<string> GenerateTokeAsync(string email, string password);
    }
}
