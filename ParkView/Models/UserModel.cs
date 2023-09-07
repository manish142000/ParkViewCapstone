using System.ComponentModel.DataAnnotations.Schema;

namespace ParkView.Models
{
    public class UserModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [NotMapped]
        public string TransactionId { get; set; }

        [NotMapped]
        public string OrderId { get; set; }
    }
}
