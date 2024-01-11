using System.ComponentModel.DataAnnotations;

namespace ExamenProject.Models
{
    public class Member
    {
        public int Id { get; set; }

        [Display(Name = "Naam")]
        public string Name { get; set; }

        [Display(Name = "Familienaam")]
        public string LastName { get; set; }

        [Display(Name = "Adress")]
        public string Adress { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        public List<Book> Books { get; set; }
    }
}
