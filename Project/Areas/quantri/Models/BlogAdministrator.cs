using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Areas.quantri.Models
{
    [Table("BlogAdministrator")]
    public class BlogAdministrator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Hãy nhập tên người dùng")]
        [StringLength(64,ErrorMessage = "Tên đăng nhập phải trong khoảng 3-64 ký tự",MinimumLength = 3)]
        [Column(TypeName ="varchar")]
        [Display(Name ="Tên Đăng nhập")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Hãy Nhập Mật Khẩu")]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        [Display(Name ="Mật Khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public ICollection<BlogGrantPermission> GetBlogGrantPermission { get; set; }
    }
}