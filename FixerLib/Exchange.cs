using System.Collections.Generic;

namespace FixerLib
{
    public class Exchange
    {
        public string Base { get; set; }
        public string Date { get; set; }
        public Dictionary<string, float> Rates { get; set; }
    }
}