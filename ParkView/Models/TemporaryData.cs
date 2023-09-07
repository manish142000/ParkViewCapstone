namespace ParkView.Models
{
    public class TemporaryData
    {
        public int TemporaryDataId { get; set; }

        public DateTime checkin { get; set; }
        
        public DateTime checkout { get; set; } 

        public int hotel { get; set; }
    }
}
