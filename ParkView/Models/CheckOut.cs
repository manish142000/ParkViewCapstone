using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ParkView.Models
{
    public class CheckOut
    {
        public int CheckOutId { get; set; }


        [Required(ErrorMessage = "Please Enter your Full Name")]
        [Display(Name = "Full Name")]
        [StringLength(30)]
        public string FullName { get; set; }


        [Required]
        [StringLength(50)]
        public string Address { get; set; }


        [Required(ErrorMessage = "Please Enter your Ëmail")]
        [Display(Name = "Email Address")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Enter Phone Number")]
        [Display(Name = "Phone Number")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        
        public double OrderTotal { get; set; }

        
        public DateTime OrderPlacedOn { get; set; } = DateTime.Now;


        public List<BookingCartItem> bookingCartItems { get; set; }

        public DateTime check_in { get; set; } = DateTime.Now;


        public DateTime check_out { get; set; } = DateTime.Now.AddDays(1);

    }
}
