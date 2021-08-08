
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Kullanici : IEntity
    {
        public int KullaniciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string OdenecekTutar { get; set; }
        public string ParaBirimi { get; set; }
        public string Aciklama { get; set; }
        public Guid Guid { get; set; }
    }
}
