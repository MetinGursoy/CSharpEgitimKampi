﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mainsubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("selam");

            //Console.WriteLine("***yemek Katagorileri***");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***yemek Katagorileri***"); 

            #endregion

            #region String Değişkenler

            //String
            //Değişken_Türü Değişken_adı;

            //string name;
            //name="Metin";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city= "İstanbul";

            //Console.WriteLine("***Rezervasyon Kartı***");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri:"+ customerName +" "+ customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");
            //customerName = "Ayşegül";


            //Console.WriteLine();
            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");



            #endregion

            #region Int Değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***Restoran Menü Fiyatı***");
            Console.WriteLine();
            Console.WriteLine("----Hamburger Fiyatı:" + hamburgerPrice + "TL");
            Console.WriteLine("----Kola Fiyatı:" + cokePrice + "TL");
            Console.WriteLine("----Su Fiyatı:" + waterPrice + "TL");
            Console.WriteLine("----Kızartma Fiyatı:" + friesPrice + "TL");
            Console.WriteLine("----Pizza Fiyatı:" + pizzaPrice + "TL");
            Console.WriteLine("----Limonata Fiyatı:" + lemonadePrice + "TL");
            Console.WriteLine();

            Console.WriteLine("***Restoran Menü Fiyatı***");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;



            hamburgerCount = 3;
            cokeCount=3;
            waterCount=3;
            friesCount=1;
            pizzaCount=0;
            lemonadeCount=0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;
            totalLemonadePrice= lemonadeCount * lemonadePrice;



            Console.WriteLine("-------------------------");
            Console.WriteLine("Hamburger tutarı:" + totalHamburgerPrice + "TL");
            Console.WriteLine("Pizza tutarı:" + totalPizzaPrice + "TL");
            Console.WriteLine("Kızartma tutarı:" + totalFriesPrice + "TL");
            Console.WriteLine("Kola tutarı:" + totalCokePrice + "TL");
            Console.WriteLine("Limonata tutarı:" + totalLemonadePrice + "TL");
            Console.WriteLine("Su tutarı:" + totalWaterPrice + "TL");
            Console.WriteLine();

            int totalPrice= totalHamburgerPrice + totalLemonadePrice+totalPizzaPrice+totalFriesPrice+totalCokePrice+totalWaterPrice;

            Console.WriteLine("Toplam Ödenecek Tutar:" + totalPrice + "TL");

            #endregion
            Console.Read();
        } 
    }
}




//Yazdırma Komutları