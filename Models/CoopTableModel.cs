using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace BrnasM3.Models
{
    /// <summary>
    /// Represents  Co-op Table model, which contains information of co-op.
    /// </summary>
    public class CoopTableModel
    {
        /// <summary>
        /// Gets,sets the title of the co-op table.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets, sets an array of co-op information.
        /// </summary>
        public CoopInformation[] coopInformation { get; set; }

        /// <summary>
        /// Represents information about employer, degree, city, and term.
        /// </summary>
        public class CoopInformation
        {
            /// <summary>
            /// Gets, sets the name of the employer.
            /// </summary>
            public string Employer { get; set; }

            /// <summary>
            /// Gets, sets the degree associated with the co-op.
            /// </summary>
            public string Degree { get; set; }

            /// <summary>
            /// Gets, sets the city where the co-op located.
            /// </summary>
            public string City { get; set; }

            /// <summary>
            /// Gets, sets the term during the co-op.
            /// </summary>
            public string Term { get; set; }
        }

        /// <summary>
        /// get instance of the rest api IST endpoint.
        /// </summary>
        /// <returns>Instance of  CoopTableModelView.</returns>
        public static async Task<CoopTableModelView> GetCoopTableModelViewAsync()
        {
            // http request which returns a parsed string
            string json = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/employment/");
            return JsonConvert.DeserializeObject<CoopTableModelView>(json);
        }

    }
}
