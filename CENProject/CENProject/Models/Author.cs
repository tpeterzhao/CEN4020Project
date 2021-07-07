using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CENProject.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        [StringLength(50), Required]
        public string FirstName { get; set; }
        [StringLength(1)]
        public string MiddleInitial { get; set; }
        [StringLength(50), Required]
        public string LastName { get; set; }
        [StringLength(50), Required]
        public string Affiliation { get; set; }
        [StringLength(50), Required]
        public string Department { get; set; }
        [StringLength(50), Required]
        public string Address { get; set; }
        [StringLength(50), Required]
        public string City { get; set; }
        [StringLength(2), Required]
        public string State { get; set; }
        [StringLength(10), Required]
        public string ZipCode { get; set; }
        [StringLength(50), Required]
        public string PhoneNumber { get; set; }
        [StringLength(100), Required]
        public string EmailAddress { get; set; }
        [StringLength(5), Required]
        public string Password { get; set; }
    }
}
