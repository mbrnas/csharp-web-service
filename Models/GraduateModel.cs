using System;
using Newtonsoft.Json;
namespace BrnasM3.Models
{
    public class GraduateModel
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string[] concentrations { get; set; }
        public string[] availableCertificates { get; set; }

        public static async Task<GraduateModelView> GetGraduateModelViewAsync()
        {
            string json = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/degrees/graduate");
            return JsonConvert.DeserializeObject<GraduateModelView>(json);
        }
    }
}

