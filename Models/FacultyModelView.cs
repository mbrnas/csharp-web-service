using System;
using Newtonsoft.Json;

namespace BrnasM3.Models

{
    /// <summary>
    ///  View model of faculty members, that has title, subtitle, and an array of faculty member models.
    /// </summary>
    public class FacultyModelView
    {
        public string title { get; set; }
        public string subTitle { get; set; }
        public FacultyModel[] faculty { get; set; }

        /// <summary>
        /// Gets a FacultyModelView from the IST API.
        /// </summary>
        /// <returns>A FacultyModelView that contains information about faculty members.</returns>
        public static async Task<FacultyModelView> GetFacultyModelViewAsync()
        {
            string json = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/people/");
            return JsonConvert.DeserializeObject<FacultyModelView>(json);
        }
    }
}
