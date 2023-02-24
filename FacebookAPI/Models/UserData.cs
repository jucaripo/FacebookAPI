using System;
namespace FacebookAPI.Models
{
    /// <summary>
    /// User Data FacebookAPI
    /// </summary>
    public class UserData
	{
        public List<string>? em { get; set; }
        public List<string>? ph { get; set; }
        public string? client_ip_address { get; set; }
        public string? client_user_agent { get; set; }
        public string? fbc { get; set; }
        public string? fbp { get; set; }
    }
}

