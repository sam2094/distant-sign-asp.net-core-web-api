﻿using System.Collections.Generic;
using System.Linq;
using DataAccess.UnitofWork;
using Models.Dtos.CertificateDtos;
using Models.Entities;
using Models.LogicParameters.CertificateLogic;

namespace BusinessLogic.Logic.CertificateLogic
{
    public class GetDiscountTypes : LogicSingleParam<GetDiscountTypesOuput>
    {
        public GetDiscountTypes(IUnitOfWork UoW, string FirstExecutedLogicName, bool beginTransaction = false) :
                base(UoW, FirstExecutedLogicName, beginTransaction)
        { }

        public override void DoExecute()
        {
            Result.Output.DiscountTypes = new List<DiscountTypeDto>(_uow.GetRepository<DiscountType>().GetAll()
                .Select(x => (DiscountTypeDto)x));
        }
    }
}
