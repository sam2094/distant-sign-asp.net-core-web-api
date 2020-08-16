using System.Collections.Generic;
using System.Linq;
using DataAccess.UnitofWork;
using Models.Dtos.UserDtos;
using Models.Entities;
using Models.LogicParameters.UserLogic;

namespace BusinessLogic.Logic.UserLogic
{
    public class GetGenderTypes : LogicSingleParam<GetGenderTypesOutput>
    {
        public GetGenderTypes(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override void DoExecute()
        {
            Result.Output.GenderTypes = new List<GenderTypeDto>(_uow.GetRepository<GenderType>().GetAll()
                .Select(x => (GenderTypeDto)x));
        }
    }
}
