using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TiyatroBİLETİM.Enity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Kategori>()
        {
            new Kategori(){Name="Aşk", Description="Aşk sevgi"},
            new Kategori(){Name="Korku", Description="gerilim"},
            new Kategori(){Name="Aksiyon", Description="Macera"},
            new Kategori(){Name="Tarihsel", Description="Tarihsel"},
            new Kategori(){Name="Dram", Description="Dram"},
            new Kategori(){Name="Komedi",Description="Komedi"}
        };

            foreach (var kategori in kategoriler)
            {

                context.Kategoris.Add(kategori);


            }
            context.SaveChanges();

            var oyunlars = new List<Oyunlarim>()
        {
            new Oyunlarim(){Name="Kamelyalı kadın",Description="bir kadın ve erkeğin askı",Price=50,Yer=true,KategorıId=6666,IsHome=true,Id=1,Image="kamelyali-kadin.jpg",saat=16.35,},
            new Oyunlarim(){Name="KülKedisi",Description="dilekler ask kıskançlık",Price=50,Yer=true,KategorıId=6666, IsHome = true,Id=2,Image="kulkedisi.png",saat=21.35},
            new Oyunlarim(){Name="Aşk Hikayen Düşmüş",Description="iki kişinin sözleşmesi sonucu 11yıl sonra aşık olmaları",Price=50,Yer=true,KategorıId=6666, IsHome = false,Id=3,Image="ask-hikayen-dusmus.jpg",saat=16.35},
            new Oyunlarim(){Name="Eltilerin-Savaşı",Description="dilekler ask kıskançlık",Price=50,Yer=true,KategorıId=7777, IsHome = false,Id=4,Image="EltilerinSavasi.jpg", saat = 21.35,},

            new Oyunlarim(){Name="Bu diyar bir başkadır",Description="sehirden köye",Price=50,Yer=true,KategorıId=1111,IsHome = true,Id =5,Image="bu-diyar-baskadir.jpg",saat=16.35},
            new Oyunlarim(){Name="Beni Hatırlayınız",Description="bir adamın mirası",Price=50,Yer=true,KategorıId=1111,IsHome=true,Id=6,Image="beni-hatirlayiniz.jpeg",saat=21.35},
            new Oyunlarim(){Name="Kühelyan",Description="anlatılmaz yaşanır",Price=50,Yer=true,KategorıId=1111,IsHome=false,Id=7,Image="kuheylan.jpg", saat = 16.35},


            new Oyunlarim(){Name="Tenor-3",Description="bir liselinin yasadığı kuzenleriyle korku macerası",Price=50,Yer=true,KategorıId=2222, IsHome = true,Id = 8,Image="Tenor.jpg", saat = 21.35},
            new Oyunlarim(){Name="Tenor-2",Description="bir liselinin arkadaşlarıyla yasadığı korku macerası",Price=50,Yer=true,KategorıId=2222, IsHome = false,Id =9,Image="Tenor.jpg", saat = 21.35},
            new Oyunlarim(){Name="Tenor-1",Description="bir liselinin ailesiyle yasadığı korku macerası",Price=50,Yer=true,KategorıId=2222, IsHome = true,Id =10,Image="Tenor.jpg", saat = 21.35},
            new Oyunlarim(){Name="Tenor-Dönüyor",Description="bir liselinin yasadığı korku macerasının tekrarlanması",Price=50,Yer=true,KategorıId=2222, IsHome = false,Id =11,Image="Tenor.jpg", saat = 21.35},

            new Oyunlarim(){Name="RomeoVeJuliet",Description="bir kadın ve erkeğin dıramatik aşkı",Price=50,Yer=true,KategorıId=3333, IsHome = true,Id =12,Image="romeo-ve-juliet.jpg", saat = 16.35},
            new Oyunlarim(){Name="Dünya Dans Gün'ü",Description="bir kadın dans yolculuğu",Price=50,Yer=true,KategorıId=3333,IsHome=false,Id=13,Image="dunya-dans-gunu.jpg", saat = 16.35},

            new Oyunlarim(){Name="MadamButtherfly",Description="sihirli bir dadının ev halkının hayatını değiştirmesi",Price=50,Yer=true,KategorıId=4444, IsHome = true,Id=14,Image="madama-butterfly.jpg", saat = 21.35},
            new Oyunlarim(){Name="Barok Akşamı",Description="iki mafyanın arasındaki savas",Price=50,Yer=true,KategorıId=4444,IsHome=true,Id=15,Image="Barok-aksami.png", saat = 16.35},
            new Oyunlarim(){Name="Şan Konseri",Description="iki sarkıcının rekabeti",Price=50,Yer=true,KategorıId=4444,IsHome=false,Id=16,Image="san-konseri.jpg",saat = 16.35},
            new Oyunlarim(){Name="Zafer Destanı",Description="unutulmuş insanların hayatı",Price=50,Yer=true,KategorıId=5555,IsHome=true,Id=17,Image="zafer-destani.jpg",saat=16.35},

            new Oyunlarim(){Name="Celebi",Description="hazerfen ahmet celebinin hayatı",Price=50,Yer=true,KategorıId=5555, IsHome = true,Id =18,Image="celebi.jpg",saat = 16.35},
            new Oyunlarim(){Name="Çanakkale",Description="Bir Zaferin Öyküsü",Price=50,Yer=true,KategorıId=5555, IsHome = false,Id =19, Image = "canakkale.jpg",saat = 21.35},
            new Oyunlarim(){Name="Radyo-yu Osman",Description="Osmanlının sahlanışı",Price=50,Yer=true,KategorıId=5555, IsHome = false,Id =20, Image = "osman.jpeg",saat=21.35},

            new Oyunlarim(){Name="Shakespeare Operada",Description="Shakespearein oyununun canlandırılması",Price=50,Yer=true,KategorıId=1111,IsHome=true,Id=21, Image = "shakespeare-oyunu.jpg",saat=21.35},

        };


            foreach(var Oyunlarimiz in oyunlars)
            {
                context.Oyunlars.Add(Oyunlarimiz);
               
            }
            context.SaveChanges();

            base.Seed(context);
        }

    }
}