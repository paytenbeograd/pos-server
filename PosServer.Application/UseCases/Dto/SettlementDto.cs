using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosServer.Application.UseCases.Dto
{
    public class SettlementDto
    {
        public string ResponceDateTime { get; set; }
        public string TID { get; set; }
        public string Total { get; set; }
    }

    public class SearchSettlementDto
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
