﻿using System.ComponentModel.DataAnnotations;

namespace ParkView.Models
{
    public class RoomCategory
    {
        [Key]
        public int RoomCategoryId { set; get; }
        public string CategoryName { get; set; }
        public int DailyRate { get; set; }
    }
}
