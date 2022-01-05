using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250),Required]
        public string Fullname { get; set; }
        [MaxLength(150),Required]
        public string Email { get; set; }
        [MaxLength(15),Required]
        public string Phone { get; set; }
        [Column(TypeName ="nText"),Required]
        public string Text { get; set; }
        public DateTime CreateData { get; set; }
    }
}
