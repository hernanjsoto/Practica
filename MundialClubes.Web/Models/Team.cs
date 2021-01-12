using System;
using System.Collections.Generic;

#nullable disable

namespace MundialClubes.Web.Models
{
    public partial class Team
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public int? Titles { get; set; }
        public decimal? Value { get; set; }
    }
}
