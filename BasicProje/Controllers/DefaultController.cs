using BasicProje.Ornekler;
using Microsoft.AspNetCore.Mvc;

namespace BasicProje.Controllers
{
    public class DefaultController : Controller
    {
        void mesajlar()
        {
            ViewBag.m1 = "OOP Core Projesi";
            ViewBag.m2 = "N TIER ARC.";
            ViewBag.m3 = "SOLID";

        }
        void kullanicilar (string kullanici)
        {
            ViewBag.k = kullanici;
        }

        int topla()
        {
            int s1 = 10;
            int s2 = 20;
            int toplam = s1+ s2;    
            return toplam;
        }

        string musteriMesaj()
        {
            string mesaj = "Bu bir geriye değer döndüren mesajdır";
            return mesaj;   
        }
        public IActionResult Index()
        {
            mesajlar();
            kullanicilar("murat123");
            return View();
        }


        public IActionResult Urunler()
        {
            ViewBag.toplam = topla();   
               return View();
        }

        public IActionResult Musteriler()
        {
            ViewBag.musterimesaj =musteriMesaj();

            kullanicilar("admin123");
            return View();
        }

        public IActionResult Deneme()
        {
           Sehirler sehirler = new Sehirler();  
            sehirler.Id = 1;
            sehirler.Ad = "Afyon";
            sehirler.Nufus = 7566882;
            sehirler.Ulke = "Türkiye";
            sehirler.renk1 = "Sarı";
            sehirler.renk2 = "Kırmızı";
            sehirler.renk3 = "Beyaz";

            ViewBag.s1 = sehirler.Id;
            ViewBag.s2 = sehirler.Ad;
            ViewBag.s3 = sehirler.Nufus;
            ViewBag.s4 = sehirler.Ulke;
            ViewBag.s5 = sehirler.renk1;
            ViewBag.s6 = sehirler.renk2;
            ViewBag.s7 = sehirler.renk3;





            return View();
        }

    }
}
