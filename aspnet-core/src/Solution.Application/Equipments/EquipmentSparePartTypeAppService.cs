using System;
using Solution.Permissions;
using Solution.Equipments.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Solution.Localization;
using System.Threading.Tasks;
using System.Linq;
using Volo.Abp;

namespace Solution.Equipments
{
    public class EquipmentSparePartTypeAppService : CrudAppService<EquipmentSparePartType, EquipmentSparePartTypeDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateEquipmentSparePartTypeDto, CreateUpdateEquipmentSparePartTypeDto>,
        IEquipmentSparePartTypeAppService
    {
        protected override string GetPolicyName { get; set; } = SolutionPermissions.EquipmentSparePartTypes.Default;
        protected override string GetListPolicyName { get; set; } = SolutionPermissions.EquipmentSparePartTypes.Default;
        protected override string CreatePolicyName { get; set; } = SolutionPermissions.EquipmentSparePartTypes.Create;
        protected override string UpdatePolicyName { get; set; } = SolutionPermissions.EquipmentSparePartTypes.Update;
        protected override string DeletePolicyName { get; set; } = SolutionPermissions.EquipmentSparePartTypes.Delete;

        public EquipmentSparePartTypeAppService(IRepository<EquipmentSparePartType, Guid> repository) : base(repository)
        {
            LocalizationResource = typeof(SolutionResource);
        }

        public override async Task<EquipmentSparePartTypeDto> CreateAsync(CreateUpdateEquipmentSparePartTypeDto input)
        {
            await CheckCreatePolicyAsync();

            if (Repository.Any(a => a.Name == input.Name))
            {
                throw new UserFriendlyException(message: L["Error"], details: L["NameAlreadyExists", input.Name]);
            }

            var entity = MapToEntity(input);

            TryToSetTenantId(entity);

            await Repository.InsertAsync(entity, autoSave: true);

            return MapToGetOutputDto(entity);
        }

    }
}