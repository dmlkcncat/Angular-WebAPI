using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFLinkDal : EFEntityRepositoryBase<Link, LinkOlusturContext>, ILinkDal
    {
        public List<LinkDetailDto> GetLinkDetails()
        {
            using (LinkOlusturContext context = new LinkOlusturContext())
            {
                var result = from p in context.Link
                             join k in context.Kullanici
                             on p.KullaniciId equals k.KullaniciId
                             select new LinkDetailDto
                             {
                                 LinkId = p.LinkId,
                                 Ad = k.Ad,
                                 Soyad = k.Soyad,
                                 Mail = k.Mail,
                                 Tel = k.Tel,
                                 OdenecekTutar = k.OdenecekTutar,
                                 ParaBirimi = k.ParaBirimi,
                                 Aciklama = k.Aciklama,
                                 KullaniciId = k.KullaniciId,
                                 OlusturmaTarihi = p.OlusturmaTarihi.Date,
                                 OdemeLinki = p.OdemeLinki,
                                 LinkGecerlilikTarihi = p.LinkGecerlilikTarihi

                             };
                return result.ToList();
            }
        }
    }
}
