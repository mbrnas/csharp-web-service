using System;
using Newtonsoft.Json;
namespace BrnasM3.Models
{
    /// <summary>
    /// Represents RIT graduate program and the information for it.
    /// </summary>
    public class GraduateModel
    {
        /// <summary>
        /// The getters and setters for the graduate degree.
        /// </summary>
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string[] concentrations { get; set; }
        public string[] availableCertificates { get; set; }

        /// <summary>
        /// Gets GraduateModelView instance from RIT's API.
        /// </summary>
        public static async Task<GraduateModelView> GetGraduateModelViewAsync()
        {
            string json = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/degrees/graduate");
            return JsonConvert.DeserializeObject<GraduateModelView>(json);
        }
    }
}

