using System;
using Newtonsoft.Json;
namespace BrnasM3.Models
{
	public class UndergraduateModel
	{
            public string degreeName { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string[] concentrations { get; set; }

		public static async Task<UndergraduateModelView> GetUndergraduateModelViewAsync()
		{
			string json = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/degrees/undergraduate");
			return JsonConvert.DeserializeObject<UndergraduateModelView>(json);
		}
	}
}

