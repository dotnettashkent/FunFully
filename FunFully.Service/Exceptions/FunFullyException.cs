namespace FunFully.Service.Exceptions
{
    public class FunFullyException : Exception
    {
        public int Code { get; set; }

        public FunFullyException(int code, string message = "Something wrong") : base(message)
        {
            this.Code = code;
        }
    }
}
