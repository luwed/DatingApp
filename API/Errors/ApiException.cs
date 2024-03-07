namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int statsuCode, string message, string details)
        {
            StatsuCode = statsuCode;
            Message = message;
            Details = details;
        }

        public int StatsuCode { get; set; }

        public string Message { get; set; }

        public string Details { get; set; }
    }
}
