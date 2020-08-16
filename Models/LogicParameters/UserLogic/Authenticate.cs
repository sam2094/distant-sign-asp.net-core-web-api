using Common.Resources;
using FluentValidation;

namespace Models.LogicParameters.UserLogic
{
	public class AuthenticateInput : LogicInput
	{
		public string Username { get; set; }
		public string Password { get; set; }

		public static implicit operator AuthenticateInput(AuthenticateInputDto v)
		{
			return new AuthenticateInput
			{
				Username = v.Username,
				Password = v.Password
			};
		}
	}

	public class AuthenticateInputDto
	{
		public string Username { get; set; }
		public string Password { get; set; }
	}

	public class AuthenticateOutput : LogicOutput
	{
		public int UserId { get; set; }
		public string Token { get; set; }
	}

	public class AuthenticateInputValidator : AbstractValidator<AuthenticateInputDto>
	{
		public AuthenticateInputValidator()
		{
			RuleFor(t => t.Username).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.USERNAME));

			RuleFor(t => t.Password).NotEmpty().WithMessage(x => string.Format(Resource.NOTEMPTY, Resource.PASSWORD));
		}
	}
}
