using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BrnasM3.Models
{ /// <summary>
  /// Represents a model that containts information about professional employment.
  /// </summary>
    public class EmploymentTableModel
    {
        /// <summary>
        /// Gets, sets the title of employment table.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets, sets an array of professional employment info .
        /// </summary>
        public EmploymentInformation[] professionalEmploymentInformation { get; set; }

        /// <summary>
        /// Represents info about an employee and their employment.
        /// </summary>
        public class EmploymentInformation
        {
            public string Employer { get; set; }
            public string Degree { get; set; }
            public string City { get; set; }
            public string Title { get; set; }
            public string StartDate { get; set; }
        }

        /// <summary>
        /// Gets view model of Employment Table.
        /// </summary>
        public static async Task<EmploymentTableModelView> GetEmploymentTableModelViewAsync()
        {
            string json = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/employment/");
            return JsonConvert.DeserializeObject<EmploymentTableModelView>(json);
        }
    }
}
