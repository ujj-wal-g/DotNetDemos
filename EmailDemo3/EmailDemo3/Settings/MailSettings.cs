using System.ComponentModel.DataAnnotations;

namespace EmailDemo3.Settings
{
    public class MailSettings
    {
        
        public string  Mail { get; set; }

        public string  DisplayName { get; set; }
        public string  Password { get; set; }
        public string  Host { get; set; }
        public int Port { get; set; }
    }
}
