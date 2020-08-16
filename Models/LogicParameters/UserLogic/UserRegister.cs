using Common.Resources;
using FluentValidation;

namespace Models.LogicParameters.UserLogic
{
    public class UserRegisterInput : LogicInput
    {
        public int RoleId { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Pin { get; set; }
        public byte StatusId { get; set; }
        public byte GenderTypeId { get; set; }
        public byte CitizenTypeId { get; set; }
        public string Password { get; set; }

        public static implicit operator UserRegisterInput(UserRegisterInputDto v)
        {
            return new UserRegisterInput
            {
                RoleId = v.RoleId,
                Fullname = v.Fullname,
                Username = v.Username,
                Pin = v.Pin,
                StatusId = v.StatusId,
                GenderTypeId = v.GenderTypeId,
                CitizenTypeId = v.CitizenTypeId,
                Password = v.Password
            };
        }
    }

    public class UserRegisterInputDto
    {
        public int RoleId { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Pin { get; set; }
        public byte StatusId { get; set; }
        public byte GenderTypeId { get; set; }
        public byte CitizenTypeId { get; set; }
        public string Password { get; set; }
    }

    public class UserRegisterOutput : LogicOutput { }

    public class UserRegisterInputValidator : AbstractValidator<UserRegisterInputDto>
    {
        public UserRegisterInputValidator()
        {
            RuleFor(t => t.Fullname).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.FULLNAME))
                .Length(1, 20).WithMessage(x => string.Format(Resource.LENGTH, Resource.FULLNAME, 2, 20));

            RuleFor(t => t.Username).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.USERNAME))
               .Length(1, 20).WithMessage(x => string.Format(Resource.LENGTH, Resource.USERNAME, 2, 20));

            RuleFor(t => t.Pin).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.PIN))
               .Length(1, 8).WithMessage(x => string.Format(Resource.LENGTH, Resource.PIN, 1, 8));

            RuleFor(t => t.Password).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.PASSWORD))
               .Length(1, 30).WithMessage(x => string.Format(Resource.LENGTH, Resource.PASSWORD, 1, 30));

            //RuleFor(t => t.Email).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.EMAİL))
            //	.EmailAddress().WithMessage(Resource.EMAIL_IS_NOT_VALID);
        }
    }
}
