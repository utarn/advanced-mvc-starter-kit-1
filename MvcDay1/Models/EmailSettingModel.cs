namespace MvcDay1.Models
{
    // https://myaccount.google.com/lesssecureapps
    public class EmailSettingModel
    {
        public string Host { get; set; } = default!;
        public int Port { get; set; } = default!;
        public string User { get; set; } = default!;
        public string Password{ get; set; } = default!;
    }
}
