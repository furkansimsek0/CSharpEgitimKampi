using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            ////double number;
            ////number = 6.14;

            ////Console.WriteLine(number);

            //Console.WriteLine("---------- Fiyat Listesi ----------");
            //Console.WriteLine();

            //double  applePrice, 
            //        orangePrice, 
            //        strawberryPrice, 
            //        potatoPrice, 
            //        tomatoPrice;


            //(applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice) =(15.66,22.32,49,13.13,9.98);

            //Console.WriteLine(   "----> Elma Birim Fiyatı:"     + applePrice        + " TL\n"
            //                    +"----> Portakal Birim Fiyatı:" + orangePrice       + " TL\n"
            //                    +"----> Çilek Birim Fiyatı:"    + strawberryPrice   + " TL\n"
            //                    +"----> Patates Birim Fiyatı:"  + potatoPrice       + " TL\n"
            //                    +"----> Domates Birim Fiyatı:"  + tomatoPrice       + " TL\n");

            //Console.WriteLine();

            //double  appleGram, 
            //        orangeGram, 
            //        strawberryGram, 
            //        potatoGram, 
            //        tomatoGram;

            //appleGram = 2.442;
            //orangeGram = 4.752;
            //strawberryGram = 1.015;
            //potatoGram = 6.644;
            //tomatoGram = 0.971;

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice;

            //(appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice) = (   (appleGram * applePrice),
            //                                                                                                    (orangeGram * orangePrice),
            //                                                                                                    (strawberryGram * strawberryPrice),
            //                                                                                                    (potatoGram * potatoPrice),
            //                                                                                                    (tomatoGram * tomatoPrice));


            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler


            //char symbol;
            //symbol = 's';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("----- Anonim Hava Yolları Yolcu Bilgisi -----");
            //Console.WriteLine();

            //string passengerName,
            //       passengerSurname,
            //       passengerDistrict,
            //       passengerCity,
            //       passengerAge,
            //       passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber
            //                  +  " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " "
            //                  + passengerDistrict  + " / " + passengerCity + " "
            //                  + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //
            //shoesPrice = 4000;
            //computerPrice = 30000;
            //chairPrice = 8000;
            //tvPrice = 18000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice =   shoesCount * shoesPrice
            //                 + computerCount * computerPrice
            //                 + chairCount * chairPrice
            //                 + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödenecek Tutar: " +  totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double not1, not2, not3, sonuc;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //not1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //not2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //not3 = double.Parse(Console.ReadLine());

            //sonuc = (not1 + not2 + not3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + sonuc);

            #endregion

            #region Klavyeden Karakter Girişleri

            char cinsiyet;
            Console.Write("Lütfen cinsiyet seçiniz(e/k): ");
            cinsiyet = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + cinsiyet);

            #endregion


            Console.Read();
        }
    }
}
