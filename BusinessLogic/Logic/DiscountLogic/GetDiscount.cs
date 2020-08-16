using System.Threading.Tasks;
using Common;
using Common.Enums.ErrorEnums;
using Common.Resources;
using DataAccess.UnitofWork;
using Models.Entities;
using Models.LogicParameters.DiscountLogic;

namespace BusinessLogic.Logic.DiscountLogic
{
    public class GetDiscount : Logic<int, GetDiscountOutput>
    {
        public GetDiscount(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {
            Discount discount = await _uow.DiscountRepository.GetAsync(x => x.Id == Parameters, i => i.DiscountType);

            if (discount == null)
            {
                Result.ErrorList.Add(new Error
                {
                    ErrorCode = ErrorCodes.DISCOUNT_DOES_NOT_EXIST,
                    ErrorMessage = Resource.DISCOUNT_DOES_NOT_EXIST,
                    StatusCode = ErrorHttpStatus.NOT_FOUND
                });
                return;
            }

            Result.Output.Discount = discount;
        }
    }
}
