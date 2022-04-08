using Newtonsoft.Json;

namespace LandingPage.Data
{
    public class TypeformContactUsPayload
    {
        [JsonProperty(PropertyName = "form_response")]
        public FormResponse? Response { get; set; }
    }

    public class FormResponse
    {
        [JsonProperty(PropertyName = "form_id")]
        public string? FormId { get; set; }

        [JsonProperty(PropertyName = "token")]
        public string? Token { get; set; }

        [JsonProperty(PropertyName = "answers")]
        public List<Answers>? Answers { get; set; }
    }

    public class Answers
    {
        [JsonProperty(PropertyName = "email")]
        public string? Email { get; set; }
    }
}
