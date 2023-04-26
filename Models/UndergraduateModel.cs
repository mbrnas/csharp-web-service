using System;
using Newtonsoft.Json;
namespace BrnasM3.Models
{
    /// <summary>
    ///This is the Undergrad model which holds basic information such as degree name, title, description, and concentrations.
    /// </summary>
    public class UndergraduateModel
	{
            public string degreeName { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string[] concentrations { get; set; }

        /// <summary>
        /// Gets instance of the UndergraduateModelView class, that has array of UndergraduateModel instances that hold info about undergrad.
        /// </summary>
        public static async Task<UndergraduateModelView> GetUndergraduateModelViewAsync()
		{
			string json = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/degrees/undergraduate");
			return JsonConvert.DeserializeObject<UndergraduateModelView>(json);
		}
	}
}

