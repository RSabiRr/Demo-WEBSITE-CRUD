using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [MaxLength(100)]
        public string Content { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string AboutTitle1 { get; set; }
        [MaxLength(1000)]
        public string AboutTitle2 { get; set; }
        [MaxLength(500)]
        public string Adress { get; set; }


    }
}
