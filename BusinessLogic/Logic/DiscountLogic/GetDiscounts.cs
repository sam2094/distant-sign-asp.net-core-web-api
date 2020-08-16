using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.UnitofWork;
using Models.Dtos.DiscountDtos;
using Models.Entities;
using Models.LogicParameters.DiscountLogic;

namespace BusinessLogic.Logic.DiscountLogic
{
    public class GetDiscounts : LogicSingleParam<GetDiscountsOutput>
    {
        public GetDiscounts(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override async Task DoExecuteAsync()
        {
            List<Discount> discounts = _uow.DiscountRepository.GetAll(i => i.DiscountType).ToList();
            Result.Output.Discounts = new List<GetDiscountsDto>(discounts.Select(x => (GetDiscountsDto)x));
            await Task.CompletedTask;
        }
    }
}
