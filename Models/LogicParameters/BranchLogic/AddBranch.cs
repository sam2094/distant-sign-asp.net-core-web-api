using Common.Resources;
using FluentValidation;
using Models.Dtos.BranchDtos;

namespace Models.LogicParameters.BranchLogic
{
    public class AddBranchInput
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int OrganizationId { get; set; }
    }

    public class AddBranchOutput : LogicOutput
    {
        public AddBranchDto Branch { get; set; }
    }

    public class AddBranchInputValidator : AbstractValidator<AddBranchInput>
    {
        public AddBranchInputValidator()
        {
            RuleFor(t => t.Name).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.NAME))
                .Length(2, 50).WithMessage(x => string.Format(Resource.LENGTH, Resource.NAME, 2, 50));

            RuleFor(t => t.Address).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.ADDRESS))
               .Length(2, 50).WithMessage(x => string.Format(Resource.LENGTH, Resource.ADDRESS, 2, 50));
        }
    }
}
