using System;
using System.Collections.Generic;

#nullable disable

namespace GeographyTest.Models
{
    public partial class MountainsCountry
    {
        public int MountainId { get; set; }
        public string CountryCode { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
        public virtual Mountain Mountain { get; set; }
    }
}
