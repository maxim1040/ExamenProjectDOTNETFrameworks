using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenProject.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Titel")]
        public string Titel { get; set; }

        [Display(Name = "Auteur")]
        public string Auteur { get; set; }

        [Display(Name = "Omschrijving")]
        public string Omschrijving { get; set; }

        [ForeignKey("Member")]
        [Display(Name = "Member")]
        public int MemberId { get; set; }

        public Member Member { get; set; }
    }
}
