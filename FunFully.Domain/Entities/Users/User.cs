using FunFully.Domain.Commons;
using FunFully.Domain.Entities.Moneys;

namespace FunFully.Domain.Entities.Users
{
    public class User : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public long MoneyId { get; set; }
        public Money Money { get; set; }
    }
}
