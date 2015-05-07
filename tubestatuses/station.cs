using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tubestatuses
{
    public class ValidityPeriod
    {
        public DateTime fromDate { get; set; }
        public bool isNow { get; set; }
    }

    public class Disruption
    {
        public string category { get; set; }
        public string categoryDescription { get; set; }
        public string additionalInfo { get; set; }
        public DateTime created { get; set; }
        public IEnumerable<string/*?*/> affectedRoutes { get; set; }
        public IEnumerable<string/*?*/> affectedStops { get; set; }
        public bool isBlocking { get; set; }
        public string closureText { get; set; }
    }

    public class LineStatus
    {
        public string id { get; set; }
        public int statusSeverity { get; set; }
        public string statusSeverityDescription { get; set; }
        public DateTime created { get; set; }
        public IEnumerable<ValidityPeriod> validityPeriods { get; set; }
        public Disruption disruption { get; set; } // May be null
        public string reason { get; set; } //May be null.
    }

    public class Line
    {
        public string id { get; set; }
        public string name { get; set; }
        public string modeName { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public IEnumerable<string> disruptedNaptanIds { get; set; }
        public IEnumerable<LineStatus> lineStatuses { get; set; }
        public IEnumerable<string/*?*/> routeSections { get; set; }
    }
}