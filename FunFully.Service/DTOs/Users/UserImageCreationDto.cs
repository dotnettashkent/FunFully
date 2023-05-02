using Microsoft.AspNetCore.Http;

namespace FunFully.Service.DTOs.Users
{
    public class UserImageCreationDto
    {
        public IFormFile Image { get; set; }
        public long UserId { get; set; }
    }
}
