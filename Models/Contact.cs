using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Contact
    {
        public string CName { get; set; }
        [Key]
        public string CEmail { get; set; }
        public string CPhone { get; set; }
       
        public string Cqueries { get; set; }
    }
}