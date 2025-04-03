using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PosServer.Application.UseCases.Dto
{
    public class PaymentResponseDto
    {
        //public int Responsecode { get; set; }
        //public string ResponseText { get; set; }





        //public string Message { get; set; }

        //private int responceCode;
        //public int ResponceCode
        //{
        //    get => responceCode; set
        //    {
        //        responceCode = value;
        //        switch (value)
        //        {
        //            case 0: ResponceText = "Success"; break;
        //            case 1: ResponceText = "PC serial port unavailable"; break;
        //            case 2: ResponceText = "No ACK or NACK"; break;
        //            case 3: ResponceText = "Function TimeOut"; break;
        //            case 4: ResponceText = "Invalid input"; break;
        //            case 5: ResponceText = "Configuration file missing"; break;
        //            case 6: ResponceText = "Invalid Product Key"; break;
        //            case 7: ResponceText = "POS error"; break;
        //            case 8: ResponceText = "POS TCP socket unreachable"; break;
        //            case 9: ResponceText = "Cannceled transaction"; break;
        //        }
        //    }
        //}
        //public string ResponceText { get; set; }
        ////[JsonIgnore]
        //public TransParamsV3 TransParams { get; set; }
        //[JsonIgnore]
        //public ECR.DCCData DccData { get; set; }
        //public List<ECR.TotalV3New> Total { get; set; }

        ////[JsonIgnore]
        //public List<ECR.TransDetV3> TransDet { get; set; }
    }

    public class EcrTransParams
    {

    }
}
