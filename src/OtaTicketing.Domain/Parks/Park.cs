using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace OtaTicketing.Parks
{
    /// <summary>
    /// 公园信息
    /// </summary>
    public class Park : FullAuditedAggregateRoot<int>
    {
        /// <summary>
        /// 业务主键
        /// </summary>
        [Required]
        [Range(1, 255)]
        public short ParkCode { get; set; }

        /// <summary>
        /// 公园名称
        /// </summary>
        [Required]
        [StringLength(40)]
        public string ParkName { get; set; }

        /// <summary>
        /// 账户名称
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary>
        [Required]
        public int AddressId { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [StringLength(20)]
        public string Email { get; set; }

        /// <summary>
        /// 传真
        /// </summary>
        [StringLength(20)]
        public string Fax { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [StringLength(20)]
        public string Tel { get; set; }

        

        /// <summary>
        /// (是否有效)
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// 默认排序
        /// </summary>
        public int SerialNumber { get; set; }
    }
}
