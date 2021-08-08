using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // KullaniciTest();
            LinkTest();
            Console.ReadLine();
        }

        private static void KullaniciTest()
        {
            KullaniciManager kullaniciManager = new KullaniciManager(new EFKullaniciDal());
            foreach (var item in kullaniciManager.GetAll())
            {
                Console.WriteLine(item.Ad);
                
            }
        }
        private static void LinkTest()
        {
            LinkManager linkmanager = new LinkManager(new EFLinkDal());
            foreach (var item in linkmanager.GetLinkDetails())
            {
                Console.WriteLine(item.Ad + item.Soyad + item.Mail + item.Tel + item.OdenecekTutar + item.ParaBirimi + item.Aciklama + item.OlusturmaTarihi + item.OdemeLinki + item.LinkGecerlilikTarihi);

   
            }
        }
    }
}
