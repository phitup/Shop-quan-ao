using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project.Areas.quantri.Models
{
    [Table("BlogGrantPermission")]
    public class BlogGrantPermission
    {
        [Key]
        [Column(Order = 2)]
        [ForeignKey("BlogAdministrator")]
        [Display(Name = "Mã người dùng")]
        [Required]
        public int UserId { get; set; }

        [Display(Name = "Mô Tả")]
        [MaxLength(256)]
        public string Description { get; set; }

        public virtual BlogAdministrator BlogAdministrator { get; set; }
    }
}