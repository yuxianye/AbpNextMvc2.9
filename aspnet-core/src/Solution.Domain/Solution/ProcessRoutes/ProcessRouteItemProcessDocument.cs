using Solution.Equipments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Solution.ProcessRoutes
{
    /// <summary>
    /// 工艺路线明细-工艺文件
    /// </summary>
    public class ProcessRouteItemProcessDocument : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 工艺路线明细编号
        /// </summary>
        public Guid ProcessRouteItemId { get; set; }

        /// <summary>
        /// 工艺路线明细
        /// </summary>
        [ForeignKey(nameof(ProcessRouteItemId))]
        public virtual ProcessRouteItem ProcessRouteItem { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 工艺文件类型编号
        /// </summary>
        public Guid ProcessDocumentTypeId { get; set; }

        /// <summary>
        /// 工艺文件类型
        /// </summary>
        [ForeignKey(nameof(ProcessDocumentTypeId))]
        public virtual ProcessDocumentType ProcessDocumentType { get; set; }

        /// <summary>
        /// 关联设备编号
        /// </summary>
        public Guid EquipmentId { get; set; }

        /// <summary>
        /// 关联设备
        /// </summary>
        [ForeignKey(nameof(EquipmentId))]
        public virtual Equipment Equipment { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }
}
