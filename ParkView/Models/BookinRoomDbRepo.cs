namespace ParkView.Models
{
    public class BookinRoomDbRepo : IBookingRoom
    {
        private readonly HotelDbContext _context;
        public BookinRoomDbRepo( HotelDbContext context )
        {
            _context = context;
        }
        public List<BookingRoom> BookedRooms()
        {
            return _context.bookingRooms.ToList();
        }
    }
}
