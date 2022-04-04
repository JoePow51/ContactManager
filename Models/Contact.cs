using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        // EF Core configuration database to generate this value; int value = primary key for db
        //[Range(1, int.MaxValue, ErrorMessage = "You must have a postive number of contacts")]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter your contact's first name")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter your contact's last name")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please enter your contact's phone number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter the phone number in the correct format")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your contact's email address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter the email address in the correct format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select a category for your contact")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Organization { get; set; }

        public string Slug =>
            Firstname + Lastname;
    }
}
