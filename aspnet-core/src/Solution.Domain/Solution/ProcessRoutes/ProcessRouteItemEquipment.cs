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
    /// 工艺路线明细-设备
    /// </summary>
    public class ProcessRouteItemEquipment : FullAuditedEntity<Guid>
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
        /// 设备编号
        /// </summary>
        public Guid EquipmentId { get; set; }

        /// <summary>
        /// 设备
        /// </summary>
        [ForeignKey(nameof(EquipmentId))]
        public virtual Equipment Equipment { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }
}
