using Common.Resources;
using FluentValidation;
using Models.Dtos.BranchDtos;

namespace Models.LogicParameters.BranchLogic
{
    public class UpdateBranchInput
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class UpdateBranchOutput : LogicOutput
    {
        public AddBranchDto Branch { get; set; }
    }

    public class UpdateBranchInputValidator : AbstractValidator<UpdateBranchInput>
    {
        public UpdateBranchInputValidator()
        {
            RuleFor(t => t.Name).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.NAME))
                .Length(2, 50).WithMessage(x => string.Format(Resource.LENGTH, Resource.NAME, 2, 50));

            RuleFor(t => t.Address).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.ADDRESS))
               .Length(2, 50).WithMessage(x => string.Format(Resource.LENGTH, Resource.ADDRESS, 2, 50));
        }
    }
}
