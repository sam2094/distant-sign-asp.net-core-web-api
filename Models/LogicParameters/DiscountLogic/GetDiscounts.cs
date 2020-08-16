using Models.Dtos.DiscountDtos;
using System.Collections.Generic;

namespace Models.LogicParameters.DiscountLogic
{
    public class GetDiscountsOutput : LogicOutput
    {
        public List<GetDiscountsDto> Discounts { get; set; }
    }
}
