using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad alani zorunlu")]
        public string? Name { get; set; } //null

        [Required(ErrorMessage ="Telefon alani zorunlu")]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="EPosta alani zorunlu")]
        [EmailAddress(ErrorMessage ="Hatali email")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Katilim durumunu belirtiniz.")]
        public bool? WillAttend { get; set; }  //true, false ,null

    }
}