using System;
namespace FacebookAPI.Models
{
    /// <summary>
    /// Class FacebookDataAPI for Conversion API V16
    /// </summary>
    public class FacebookDataAPI
	{
        public string? event_name { get; set; }
        public int event_time { get; set; }
        public UserData? user_data { get; set; }
        public List<Content>? contents { get; set; }
        public CustomData? custom_data { get; set; }
        public string? event_source_url { get; set; }
        public string? action_source { get; set; }
    }
}

