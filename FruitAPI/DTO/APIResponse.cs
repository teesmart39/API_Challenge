namespace FruitAPI.DTO
{
    public class APIResponse
    {
        public string StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; }
        public object Result { get; set; }
        public string Token { get; set; }
        
    }
}
