using Core.Ultities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKullaniciService
    {
        IDataResult<List<Kullanici>> GetAll();
        IResult Add(Kullanici kullanici);
        void AddLink(Link link);
    }
}
