using System;

namespace ClassDefinition // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            // {
            //     [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //     [Erişim Belirleyici] [Geri Donus Tipi] MetotAdi([Parametre Listesi])
            //     {
            //         Metot Komutlari
            //     }
            //}

            //Erisim Belirleyiciler
            // * Public
            // * Private : Sadece tanimlandigi sinif icerisinde erisilebilen (Propertyler)
            // * Internal : Sadece kendi bulundugu proje icerisinde degiskenlere(propertylere) ve siniflara
            // * Protected : Sadece tanimlandigi sinifta veya o siniftan kalitim alan siniflarda

            Console.WriteLine("********* Calisan 1**********");

            Calisan calisan1 = new Calisan("Serkan","Özsöz",2345678,"Developer");
            calisan1.CalisanBilgileri();

            Console.WriteLine("********* Calisan 2**********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Deniz";
            calisan2.Soyad="Arda";
            calisan2.No=2345677;
            calisan2.Departman="Insan Kaynaklari";

            calisan2.CalisanBilgileri();

            Console.WriteLine("********* Calisan 3**********");
            Calisan calisan3 = new Calisan("Serkan","Ozsoz");
            calisan3.CalisanBilgileri();

            }
        }

        class Calisan
        {
            //Calisani tanimlayanlara propertyler deniliyor.
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public Calisan(string ad, string soyad, int no, string departman)
            {
                //overload edilebilir.
                //class ismiyle aynı olmalı.(constructor)
                this.Ad=ad;
                this.Soyad=soyad;
                this.No=no;
                this.Departman=departman;
            }

            public Calisan(){}

            public Calisan(string ad, string soyad)
            {
                //overload edilebilir.
                //class ismiyle aynı olmalı.(constructor)
                this.Ad=ad;
                this.Soyad=soyad;  //diğer propları 0 olarak atar.
                
            }

              //parametre almayan constructor.

            public void CalisanBilgileri()
            {
                Console.WriteLine("Calisan Adi: {0}", Ad);
                Console.WriteLine("Calisan Soyadi: {0}", Soyad);
                Console.WriteLine("Calisan Numarasi: {0}", No);
                Console.WriteLine("Calisan Departmani: {0}", Departman);
                
            }
        }
    }
