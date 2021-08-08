using Core.Ultities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ILinkService
    {
        IDataResult<List<Link>> GetAll();
        IDataResult<List<LinkDetailDto>> GetLinkDetails();
        IResult Add(Link link);
    }
}
