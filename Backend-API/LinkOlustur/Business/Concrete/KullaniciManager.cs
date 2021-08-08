using Business.Abstract;
using Business.Constans;
using Core.Ultities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public IResult Add(Kullanici kullanici)
        {
            if(kullanici.Mail.Length<15)
            {
                return new ErrorResult(Messages.KullaniciMailInvalid);
            }
            _kullaniciDal.Add(kullanici);
            return new SuccessResult(Messages.KullaniciAdded);
           
        }

        public void AddLink(Link link)
        {
            using (LinkOlusturContext context = new LinkOlusturContext())
            {
                var addedEntity = context.Entry(link);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public IDataResult<List<Kullanici>> GetAll()
        {
            return new SuccessDataResult<List<Kullanici>>(_kullaniciDal.GetAll());
        }
    }
}
