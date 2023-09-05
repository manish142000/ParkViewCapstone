using Microsoft.AspNetCore.Mvc;
using ParkView.Models;
using System.ComponentModel;

namespace ParkView.ViewModels
{
    public class IndexViewModel
    {
        [BindProperty]
        public string destination { get; set; }

        
        public DateTime check_in { get; set; } = DateTime.Now;

        
        public DateTime check_out { get; set; } = DateTime.Now.AddDays(1);

        
        public int numberRooms { get; set; }

        
        public int adultCount { get; set; }

        
        public int childrenCount { get; set; }

        public List<Room> rooms { get; set; }

        public string[] roomTypeNames { get; set; }
        public string[] imageUrls { get; set; }
        public int[] availableRooms { get; set; }

    }
}
