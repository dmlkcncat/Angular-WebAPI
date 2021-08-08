using Business.Abstract;
using Business.Constans;
using Core.Ultities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class LinkManager : ILinkService
    {
        ILinkDal _linkDal;
        public LinkManager(ILinkDal linkDal)
        {
            _linkDal = linkDal;
        }

        public IResult Add(Link link)
        {
            _linkDal.Add(link);
            return new SuccessResult(Messages.KullaniciAdded);
        }

        public IDataResult<List<Link>> GetAll()
        {
           
            return new SuccessDataResult<List<Link>>(_linkDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<LinkDetailDto>> GetLinkDetails()
        {
            return new SuccessDataResult<List<LinkDetailDto>>(_linkDal.GetLinkDetails(), Messages.Listed);
        }
    }
}
