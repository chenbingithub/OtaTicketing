using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using IdentityServer4.Models;
using Volo.Abp.Domain.Entities.Auditing;

namespace OtaTicketing.Agencies
{
    /// <summary>
    /// 代理商
    /// </summary>
    public class Agency : FullAuditedAggregateRoot<int>
    {
        #region Properties

        /// <summary>
        /// 代理商账户Id
        /// </summary>
        public int AccountId { get; set; }

        /// <summary>
        /// 城市编号
        /// </summary>
        [Required]
        public int AddressId { get; set; }

        /// <summary>
        /// 代理商类型编号
        /// </summary>
        [Required]
        public int AgencyTypeId { get; set; }

        /// <summary>
        /// 代理商主账户
        /// </summary>
        public long? MainAgencyUserId { get; set; }

        /// <summary>
        /// 上级代理商编号
        /// </summary>
        public int? ParentAgencyId { get; set; }

        /// <summary>
        /// 代理商名称
        /// </summary>
        [Required]
        [StringLength(50)]
        public string AgencyName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [StringLength(50)]
        public string Email { get; set; }

        /// <summary>
        /// 联系手机
        /// </summary>
        [StringLength(20)]
        public string Mobile { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [StringLength(20)]
        public string Tel { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(50)]
        public string Remark { get; set; }

        /// <summary>
        /// 上级代理商
        /// </summary>
        /// <value>The parent agency.</value>
        public virtual Agency ParentAgency { get; set; }

        
        /// <summary>
        /// 代理商类型
        /// </summary>
        public virtual AgencyType AgencyType { get; set; }

       

        #endregion Properties
    }
}
