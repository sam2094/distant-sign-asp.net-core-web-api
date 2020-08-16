using Common.Resources;
using FluentValidation;
using Models.Dtos.OrganizationDtos;

namespace Models.LogicParameters.OrganizationLogic
{
    public class AddOrganizationInput
    {
        public string Name { get; set; }
        public string Voen { get; set; }
        public int Account { get; set; }
        public int DiscountId { get; set; }
    }

    public class AddOrganizationOutput : LogicOutput
    {
        public AddOrganizationDto Organization { get; set; }
    }

    public class AddOrganizationInputValidator : AbstractValidator<AddOrganizationInput>
    {
        public AddOrganizationInputValidator()
        {
            RuleFor(t => t.Name).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.NAME))
                .Length(2, 50).WithMessage(x => string.Format(Resource.LENGTH, Resource.NAME, 2, 50));

            RuleFor(t => t.Voen).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.VOEN))
               .Length(1, 30).WithMessage(x => string.Format(Resource.LENGTH, Resource.VOEN, 1, 30));

            RuleFor(t => t.Account).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.ACCOUNT)); 
        }
    }
}
