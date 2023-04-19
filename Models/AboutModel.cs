using Newtonsoft.Json;

namespace BrnasM3.Models
{
    public class AboutModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Quote { get; set; }
        public string QuoteAuthor { get; set; }

        public static async Task<AboutModel> GetAboutModelAsync()
        {
            string json = await new HttpClient().GetStringAsync(
                "http://ist.rit.edu/api/about/");
            return JsonConvert.DeserializeObject<AboutModel>(json);
        }
    }
}
