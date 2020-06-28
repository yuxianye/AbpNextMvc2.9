using System;
using System.ComponentModel.DataAnnotations;
namespace Solution.Web.Pages.Equipments.EquipmentInspectionResult.ViewModels
{
    public class CreateEditEquipmentInspectionResultViewModel
    {
        [Required]
        [StringLength(MySolutionConsts.NameLength)]
        [Display(Name = "EquipmentInspectionResultName")]
        public string Name { get; set; }

        [StringLength(MySolutionConsts.RemarkLength)]
        [Display(Name = "EquipmentInspectionResultRemark")]
        public string Remark { get; set; }
    }
}