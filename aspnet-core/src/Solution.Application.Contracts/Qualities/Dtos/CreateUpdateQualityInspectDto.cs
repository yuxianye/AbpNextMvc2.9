using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Solution.Qualities.Dtos
{
    public class CreateUpdateQualityInspectDto
    {

        [Required]
        [StringLength(MySolutionConsts.CodeLength)]
        public string Code { get; set; }

        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        public string InspectPerson { get; set; }

        public Guid QualityInspectTypeId { get; set; }

        public DateTime InspectTime { get; set; }

        public Guid QualityProblemLibId { get; set; }

        public Guid QualityInspectResultId { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        public string Remark { get; set; }
    }
}