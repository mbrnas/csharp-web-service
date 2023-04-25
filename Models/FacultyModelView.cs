using System;
using Newtonsoft.Json;

namespace BrnasM3.Models
{
    public class FacultyModelView
    {
        public string title { get; set; }
        public string subTitle { get; set; }
        public FacultyModel[] faculty { get; set; }

        public static async Task<FacultyModelView> GetFacultyModelViewAsync()
        {
            string json = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/people/");
            return JsonConvert.DeserializeObject<FacultyModelView>(json);
        }
    }
}
