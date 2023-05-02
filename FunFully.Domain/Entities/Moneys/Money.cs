using FunFully.Domain.Commons;

namespace FunFully.Domain.Entities.Moneys
{
    public class Money : Auditable
    {
        public string Description { get; set; }
        public decimal AddMoney { get; set; }
        public decimal NowMoney { get; set; }
        public decimal GetMoney { get; set; }
    }
}
