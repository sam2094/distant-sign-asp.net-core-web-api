using Models.Dtos.DiscountDtos;

namespace Models.LogicParameters.DiscountLogic
{
    public class GetDiscountOutput : LogicOutput
    {
        public GetDiscountDto Discount { get; set; }
    }
}
