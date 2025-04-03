using ECR;
using PosServer.Application.UseCases.Dto;
using PosServer.Application.UseCases.Queries;
using PosServer.DataAccess;
using PosServer.Implementation.Ecr;
using System.Text.RegularExpressions;

namespace PosServer.Implementation.UseCases.Queries
{
    public class EfGetPaymentResponseQuery : IGetPaymentResponseQuery
    {
        private readonly PosServerDbContext _context;

        public EfGetPaymentResponseQuery(
            PosServerDbContext context)
        {
            _context = context;
        }

        public int Id => 3;

        public string Name => "Get payment response";

        public string Description => "Excute pay function and retrning respose to balkan bet.";

        public async Task<PaymentResponseDto> ExecuteAsync(PaymentRequestDto request)
        {
            // upisi sve u bazu
            EcrConnector ecrConnector = new EcrConnector();
            TransParamsV3 transParams = new TransParamsV3();

            FillTransParamsFromInputParams(ref transParams, request);

            var response = await ecrConnector.ExecuteTransactionAsync(transParams, "192.168.1.147:3000");

            // posalji terminalu

            // upisi response sa terminala

            // vratipodatke

            throw new NotImplementedException();
        }

        public void FillTransParamsFromInputParams(ref TransParamsV3 tp, PaymentRequestDto ip)
        {
            //idetifier se popunjava auto 00 u dll-u
            tp.TerminalId = (!String.IsNullOrEmpty(ip.TerminalID) ? ip.TerminalID.PadLeft(2, '0') : "00");
            //source ID se popunjava auto 00 u dll-u
            tp.SeqNumber = (!String.IsNullOrEmpty(ip.SeqNumber) ? ip.SeqNumber.PadLeft(4, '0') : "0000");
            tp.TransactionType = ip.TransactionType;
            tp.PrinterFlag = (!String.IsNullOrEmpty(ip.PrinterFlag) ? ip.PrinterFlag : "1");
            tp.CashierId = (!String.IsNullOrEmpty(ip.CashierID) ? ip.CashierID.PadLeft(2, '0') : "00");
            tp.TransactionNumber = (!String.IsNullOrEmpty(ip.TransactionNumber) ? ip.TransactionNumber : "");
            long.TryParse(ip.TransactionAmount, out tp.TransactionAmount1);
            //amount exponent se popunjava auto +0 u dll-u
            tp.AmountCurrency = (!String.IsNullOrEmpty(ip.AmountCurrency) ? ip.AmountCurrency : "941");
            tp.AuthorizationCode = (!String.IsNullOrEmpty(ip.AuthorisationCodeForOfflineSale) ? ip.AuthorisationCodeForOfflineSale : "");
            tp.InputLabel = "";
            tp.InsurancePolicyNumber = (!String.IsNullOrEmpty(ip.InsurancePolicyNumber) ? ip.InsurancePolicyNumber : "");
            tp.InstallmentsNumber = (!String.IsNullOrEmpty(ip.InstallmentNumber) ? ip.InstallmentNumber : "");
            //minimum input length
            //maximum input length
            //mask input data
            tp.LanguageID = (!String.IsNullOrEmpty(ip.LanguageID) ? ip.LanguageID : "00");
            if (!String.IsNullOrEmpty(ip.PrintData))
            {
                string HeaderAndFooter = "------------------------------------------------\n";

                string PreparedMessageForPrint = new string(returnPrintDataMessages(HeaderAndFooter + ip.PrintData + HeaderAndFooter));
                tp.PrintData = PreparedMessageForPrint.ToCharArray();
            }
            else
            {
                tp.PrintData = new char[] { };
            }
            tp.CashierId2 = (!String.IsNullOrEmpty(ip.CashierIDExtended) ? ip.CashierIDExtended.PadLeft(4, '0') : "");
            tp.CashAmount = (!String.IsNullOrEmpty(ip.CashAmount) ? Int16.Parse(ip.CashAmount) : 0); // Transaction amount 2
            tp.PayServices = (!String.IsNullOrEmpty(ip.Payservices) ? ip.Payservices : "");
            tp.TacData = (!String.IsNullOrEmpty(ip.TacData) ? ip.TacData : "");
            tp.IPReferenceNumber = (!String.IsNullOrEmpty(ip.IPReferenceNumber) ? ip.IPReferenceNumber : "");
            tp.qrCodeData = (!String.IsNullOrEmpty(ip.QRcodeData) ? ip.QRcodeData : "");
            tp.specificProcessingFlag = (!String.IsNullOrEmpty(ip.SpecificProcessingFlag) ? ip.SpecificProcessingFlag : "");
            //Radcom transportation specific data
        }

        private char[] returnPrintDataMessages(string message)
        {
            List<char> msg = new List<char>();

            var count = ListOfMessages(message).Count;

            foreach (string s in ListOfMessages(message))
            {
                msg.AddRange(s.ToCharArray());

                if (--count > 0)
                {
                    msg.Add(COMChars.CR);
                }
                else
                {
                    msg.Add(COMChars.FF);

                }
            }

            return msg.ToArray();
        }

        Dictionary<string, string> signs = new Dictionary<string, string>{ {"а", "a"},
{"б", "b"},
{"в", "v"},
{"г", "g"},
{"д", "d"},
{"ђ", "đ"},
{"е", "e"},
{"ж", "ž"},
{"з", "z"},
{"и", "i"},
{"ј", "j"},
{"к", "k"},
{"л", "l"},
{"љ", "lj"},
{"м", "m"},
{"н", "n"},
{"њ", "nj"},
{"о", "o"},
{"п", "p"},
{"р", "r"},
{"с", "s"},
{"т", "t"},
{"ћ", "ć"},
{"у", "u"},
{"ф", "f"},
{"х", "h"},
{"ц", "c"},
{"ч", "č"},
{"џ", "dž"},
{"ш", "š"},
{"А", "A"},
{"Б", "B"},
{"В", "V"},
{"Г", "G"},
{"Д", "D"},
{"Ђ", "Đ"},
{"Е", "E"},
{"Ж", "Ž"},
{"З", "Z"},
{"И", "I"},
{"Ј", "J"},
{"К", "K"},
{"Л", "L"},
{"Љ", "LJ"},
{"М", "M"},
{"Н", "N"},
{"Њ", "NJ"},
{"О", "O"},
{"П", "P"},
{"Р", "R"},
{"С", "S"},
{"Т", "T"},
{"Ћ", "Ć"},
{"У", "U"},
{"Ф", "F"},
{"Х", "H"},
{"Ц", "C"},
{"Ч", "Č"},
{"Џ", "Dž"},
{"Ш", "Š"} };

        private List<string> ListOfMessages(string message)
        {

            string fontType = "1";


            List<string> tempList = new List<string>();

            // remove CR from multiline textBoxses
            string temp = returnStringWithoutNewLines(message);


            string[] lines = temp.Split(new[] { "\n" }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length; i++)
            {
                string temString = String.Empty;

                if (isCyrillic(lines[i]))
                {
                    string source = lines[i];
                    foreach (KeyValuePair<string, string> pair in signs)
                    {
                        source = source.Replace(pair.Key, pair.Value);
                    }
                    temString = source;
                }
                else
                {
                    temString = lines[i];
                }


                tempList.Add(fontType + temString);
            }

            return tempList;
        }

        public bool isCyrillic(string textInput)
        {
            bool rezultat = false;
            string pattern = @"[АаБбВвГгДдЂђЕеЖжЗзИиЈјКкЛлЉљМмНнЊњОоПпРрСсТтЋћУуФфХхЦцЧчЏџШш]";
            char[] textArray = textInput.ToCharArray();
            for (int i = 0; i < textArray.Length; i++)
            {
                if (Regex.IsMatch(textArray[i].ToString(), pattern))
                {
                    rezultat = true;
                    break;
                }
            }
            return rezultat;
        }
        private string returnStringWithoutNewLines(string s)
        {
            return s.Replace("\r", "");
        }
    }
}
