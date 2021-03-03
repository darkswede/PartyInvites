using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "please enter Your name and surname")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please enter Your e-mail address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "please provide a valid e-mail address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "please enter phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "please make a choice")]
        public bool? WillAttend { get; set; }
    }
}