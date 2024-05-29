using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NVD_lession06.Models
{
    public class NvdSong
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nvd: Hãy nhập tiêu đề")]
        [DisplayName("Tiêu đề")]
        public string NvdTitle { get; set; }
        [Required(ErrorMessage = "Nvd: Hãy nhập tác giả")]
        [DisplayName("Tác giả")]
        public string NvdAuThor {  get; set; }
        [Required(ErrorMessage = "Nvd: Hãy nhập nghệ sĩ")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Nvd: Tên nghệ sĩ có tối thiểu 2 ký tự, tối đa 50 ký tự")]
        [DisplayName("Nghệ sĩ")]
        public string NvdArtist { get; set;}
        [Required(ErrorMessage = "Nvd: Hãy nhập nhà xuất bản")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="Nvd: Nhập xuất bản phải có 2 ký tự số")]
        [Range(1900,2024,ErrorMessage ="Nvd: Năm xuất bản trong khoảng 1900 - 2024")]
        [DisplayName("Năm xuất bản")]
        public int NvdYearRelease { get; set;}
    }
}