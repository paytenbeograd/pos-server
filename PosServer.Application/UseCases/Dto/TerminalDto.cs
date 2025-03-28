namespace PosServer.Application.UseCases.Dto
{
    public class TerminalDto
    {
        public string Tid { get; set; }
        public string TerminalName { get; set; }
    }

    public class SearchTerminalsDto
    {
        public string LocationCode { get; set; }
        public string HarwareId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
