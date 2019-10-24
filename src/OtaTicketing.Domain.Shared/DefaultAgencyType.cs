using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OtaTicketing
{
    /// <summary>
    /// 默认代理商类型
    /// </summary>
    public enum DefaultAgencyType
    {
        /// <summary>
        /// 其他
        /// </summary>
        [Display(Name = "其他")]
        Other = 0,

        /// <summary>
        /// 旅行社
        /// </summary>
        [Display(Name = "旅行社")]
        Travel = 10,

        /// <summary>
        /// OTA
        /// </summary>
        [Display(Name = "OTA")]
        Ota = 20,

        /// <summary>
        /// 自有渠道
        /// </summary>
        [Display(Name = "自有渠道")]
        OwnOta = 25
    }
}
