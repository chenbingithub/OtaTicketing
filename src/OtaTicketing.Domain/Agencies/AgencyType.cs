using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace OtaTicketing.Agencies
{
    /// <summary>
    /// 代理商类型 1 OTA 途牛  2 自有OTA 乐游、分销、微信、天猫、方特官网 3 旅行社 4 社会机构 如学校、政府机构、企业  A类协议组 B类协议组 旅行社组 外部旅游网组 自有电商组 （不通代理商类型享受的撤销折率不同）
    /// </summary>  
    public class AgencyType : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 代理商类型名称
        /// </summary>    
        [Required(ErrorMessage = "代理商类型是必填字段")]
        [StringLength(50)]
        public string AgencyTypeName { get; set; }

        /// <summary>
        /// 默认代理商类型
        /// </summary>
        public DefaultAgencyType DefaultAgencyType { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int SerialNumber { get; set; }


        /// <summary>
        /// 出票类型 默认、总票、分票
        /// </summary>
        public OutTicketType OutTicketType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>    
        [StringLength(50)]
        public string Remark { get; set; }

    }
}
