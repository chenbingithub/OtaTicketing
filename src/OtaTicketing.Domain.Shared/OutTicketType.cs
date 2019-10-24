using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OtaTicketing
{
    /// <summary>
    /// 出票方式
    /// </summary>
    public enum OutTicketType
    {
        /// <summary>
        /// 默认方式
        /// </summary>
        [Display(Name = "默认方式")]
        Default = 0,

        /// <summary>
        /// 总票输出
        /// </summary>
        [Display(Name = "总票输出")]
        MulTicket = 5,

        /// <summary>
        /// 分票输出
        /// </summary>
        [Display(Name = "分票输出")]
        SingleTicket = 10
    }
}
