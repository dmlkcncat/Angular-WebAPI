using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Link : IEntity
    {
        public int LinkId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public string OdemeLinki { get; set; }
        public DateTime LinkGecerlilikTarihi { get; set; }
    }
}
