using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosServer.Application.UseCases.Dto.Ecr
{
    public class DccDataDto
    {
        public string DccNumber { get; set; }
        public string DccProvider { get; set; }
        public string DccCurrency { get; set; }
        public string DccExchangeRate { get; set; }
        public string DccExchangeRateDate { get; set; }
        public string DccMarkUpPercent { get; set; }
        public string DccAmount { get; set; }
        public string DccDisclaimer { get; set; }
    }
}
