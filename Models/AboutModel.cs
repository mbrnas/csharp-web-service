using Newtonsoft.Json;

namespace BrnasM3.Models
{
    /// <summary>
    /// Represents the About model with information
    /// </summary>
    public class AboutModel
    {
        /// <summary>
        /// Gets, sets the title of About page.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets, sets description of department.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets, sets quote displayed.
        /// </summary>
        public string Quote { get; set; }

        /// <summary>
        /// Gets, sets the author of  quote displayed on website.
        /// </summary>
        public string QuoteAuthor { get; set; }

        /// <summary>
        /// Gets instance of the AboutModel from the ist rest api.
        /// </summary>
        /// <returns>instance of AboutModel</returns>
        public static async Task<AboutModel> GetAboutModelAsync()
        {
            // http request which parses response as string.
            string json = await new HttpClient().GetStringAsync(
                "http://ist.rit.edu/api/about/");
            return JsonConvert.DeserializeObject<AboutModel>(json);
        }
    }
}
