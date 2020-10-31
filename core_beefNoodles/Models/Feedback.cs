using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core_beefNoodles.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="请留下你的名字")]
        [StringLength(50,ErrorMessage ="名字不能超过20个字")]
        public string Name { get; set; }
        [Required(ErrorMessage = "请留下你的Email")]
        [StringLength(50, ErrorMessage = "Email不能超过50个字符")]
        [DataType(DataType.EmailAddress,ErrorMessage ="请填写正确的Email格式")]
        public string Email { get; set; }
        public DateTime CreateDataUTC { get; set; }
        [Required(ErrorMessage = "请留下你的反馈意见")]
        [StringLength(400, ErrorMessage = "反馈意见不能超过200个字")]
        public string Message { get; set; }
    }
}
