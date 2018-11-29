using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mews_qa_interview.Objects.Response
{

    public class GetExhangeRates
    {
        public List<Exchangerate> ExchangeRates { get; set; }
    }

    public class Exchangerate
    {
        public string SourceCurrency { get; set; }
        public string TargetCurrency { get; set; }
        public float Value { get; set; }
    }

}
