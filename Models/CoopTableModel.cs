using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BrnasM3.Models
{
    public class CoopTableModel
    {
        public string Title { get; set; }
        public CoopInformation[] coopInformation { get; set; }

        public class CoopInformation
        {
            public string Employer { get; set; }
            public string Degree { get; set; }
            public string City { get; set; }
            public string Term { get; set; }
        }

        public static async Task<CoopTableModelView> GetCoopTableModelViewAsync()
        {
            string json = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/employment/");
            return JsonConvert.DeserializeObject<CoopTableModelView>(json);

            
        }

    }
}
