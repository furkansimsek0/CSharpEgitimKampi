using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BasicSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları   

            Console.WriteLine("Welcome Dear Customer");
            Console.WriteLine("***** Eat Categories *****");
            Console.WriteLine();
            Console.WriteLine("1-Soup");
            Console.WriteLine("2-Main Dishes");
            Console.WriteLine("3-Cold Starter");
            Console.WriteLine("4-Salads");
            Console.WriteLine("5-Sweets");
            Console.WriteLine("6-Drinks");
            Console.WriteLine();
            Console.WriteLine("***** Eat Categories *****");

            #endregion

            #region String Değişkenler


            //Değişken_türü değişken_adı;

            //string name;
            //name = "Anna";
            //Console.Write(name);

            string   customerName
                    ,customerSurname
                    ,customerPhone
                    ,customerEmail
                    ,district
                    ,city;
            

            customerName        ="John";
            customerSurname     ="Bill";
            customerPhone       ="+1 100 200 30 40";
            customerEmail       ="exam@gmail.com";
            district            ="Arnavutköy";
            city                ="İstanbul";

            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Müşteri: "       + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: "      + customerPhone);
            Console.WriteLine("Email Adresi: "  + customerEmail);
            Console.WriteLine("Adres: "         + district + "/" + city);
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine();

            customerName        = "Selin";
            customerSurname     = "Zadesoy";
            customerPhone       = "+90 999 100 88 77";
            customerEmail       = "test@gmail.com";
            district            = "Nilüfer";
            city                = "Bursa";

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Müşteri: "       + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: "      + customerPhone);
            Console.WriteLine("Email Adresi: "  + customerEmail);
            Console.WriteLine("Adres: "         + district + "/" + city);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            #endregion

            #region Int Değişkenler


            int hamburgerPrice  = 170;
            int cokePrice       = 35;
            int waterPrice      = 10;
            int friesPrice      = 85;
            int pizzaPrice      = 350;
            int lemonadePrice   = 80;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: "    + hamburgerPrice    + " TL");
            Console.WriteLine("-----Pizza: "        + pizzaPrice        + " TL");
            Console.WriteLine("-----Kola: "         + cokePrice         + " TL");
            Console.WriteLine("-----Limonata: "     + lemonadePrice     + " TL");
            Console.WriteLine("-----Kızartma: "     + friesPrice        + " TL");
            Console.WriteLine("-----Su: "           + waterPrice        + " TL");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamgurgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamgurgerPrice     = hamburgerCount    * hamburgerPrice;
            totalCokePrice          = cokeCount         * cokePrice;
            totalWaterPrice         = waterCount        * waterPrice;
            totalLemonadePrice      = lemonadeCount     * lemonadePrice;
            totalFriesPrice         = friesCount        * friesPrice;
            totalPizzaPrice         = pizzaCount        * pizzaPrice;
                       
            int totalPrice =      totalCokePrice 
                                + totalWaterPrice 
                                + totalLemonadePrice 
                                + totalHamgurgerPrice 
                                + totalPizzaPrice 
                                + totalFriesPrice;

            Console.WriteLine("Sipariş Özetiniz: "+"\n"
                                                  + hamburgerCount  +" Adet Hamburger " +(totalHamgurgerPrice)  +   "TL\n"
                                                  + cokeCount       +" Adet Kola "      +(totalCokePrice)       +   "TL\n"
                                                  + waterCount      +" Adet Su "        +(totalWaterPrice)      +   "TL\n"
                                                  + friesCount      +" Adet Kızartma "  +(totalFriesPrice)      +   "TL\n"
                                                  + pizzaCount      +" Adet Pizza "     +(totalPizzaPrice)      +   "TL\n"
                                                  + lemonadeCount   +" Adet Limonata "  +(totalLemonadePrice)   +   "TL"
                                                  );

            Console.WriteLine("\nToplam Ödenecek Tutar: " + totalPrice + " TL");

            #endregion

            Console.Read();
        }
    }
}
