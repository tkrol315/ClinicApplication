namespace ClinicApp.Entities
{
    public class Request 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Message { get; set; }
        public int DayOffTypeId { get; set; }
        public DayOffType DayOffType { get; set; }
    }
}
