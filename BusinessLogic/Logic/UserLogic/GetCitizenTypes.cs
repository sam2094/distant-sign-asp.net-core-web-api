using System.Collections.Generic;
using System.Linq;
using DataAccess.UnitofWork;
using Models.Dtos.UserDtos;
using Models.Entities;
using Models.LogicParameters.UserLogic;

namespace BusinessLogic.Logic.UserLogic
{
    public class GetCitizenTypes : LogicSingleParam<GetCitizenTypesOutput>
    {
        public GetCitizenTypes(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
               base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override void DoExecute()
        {
            Result.Output.CitizenTypes = new List<CitizenTypeDto>(_uow.GetRepository<CitizenType>().GetAll()
                .Select(x => (CitizenTypeDto)x));
        }
    }

}
