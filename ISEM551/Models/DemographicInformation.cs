using System;
using System.ComponentModel;

namespace Models
{
    public class DemographicInformation
    {
        [DisplayName("FirstName")]
        public string FirstName { get; set; }

        [DisplayName("LastName")]
        public string LastName { get; set; }

        [DisplayName("Sex")]
        public string Sex { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }
    }
}
