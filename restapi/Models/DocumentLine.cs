using System;
using System.Globalization;
using Newtonsoft.Json;
using restapi.Helpers;

namespace restapi.Models
{
    public class DocumentLine
    {
        public DocumentLine() { }

        public int Week { get; set; }

        public int Year { get; set; }

        public DayOfWeek Day { get; set; }

        public float Hours { get; set; }

        public string Project { get; set; }

        public override string ToString()
        {
            return PublicJsonSerializer.SerializeObjectIndented(this);
        }
    }
}