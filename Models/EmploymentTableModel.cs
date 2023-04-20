using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BrnasM3.Models
{
    public class EmploymentTableModel
    {
        public string Title { get; set; }
        public EmploymentInformation[] professionalEmploymentInformation { get; set; }

        public class EmploymentInformation
        {
            public string Employer { get; set; }
            public string Degree { get; set; }
            public string City { get; set; }
            public string Title { get; set; }
            public string StartDate { get; set; }
        }

        public static async Task<EmploymentTableModelView> GetEmploymentTableModelViewAsync()
        {
            string json = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/employment/");
            return JsonConvert.DeserializeObject<EmploymentTableModelView>(json);
        }
    }
}
