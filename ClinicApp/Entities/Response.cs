using ClinicApp.Enums;

namespace ClinicApp.Entities
{
    public class Response
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public bool IsAccepted { get; set; }
        public bool IsSubstitution { get; set; }
        public int DayOffTypeId { get; set; }
        public Request Request { get; set; }
        public int RequestId { get; set; }
        public DayOffType DayOffType { get; set; }
    }
}
