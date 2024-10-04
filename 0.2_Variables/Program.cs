using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._2_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***Fiyat Listesi***");
            //Console.WriteLine();

            //double applePrice, OrangePrice, StrawberryPrice, PotatoPrice, TomatoPrice;

            //applePrice = 14.85;
            //OrangePrice = 20.95;
            //StrawberryPrice = 45;
            //PotatoPrice = 9.74;
            //TomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice + "TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + OrangePrice + "TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + StrawberryPrice + "TL");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + PotatoPrice + "TL");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + TomatoPrice + "TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //Console.WriteLine();

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice= orangeGram * OrangePrice;
            //double strawberryTotalPrice= strawberryGram * StrawberryPrice;
            //double potatoTotalPrice= potatoGram * PotatoPrice;
            //double tomatoTotalPrice= tomatoGram * TomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma " + "Birim Fiyat: "+applePrice + " - Gramaj: "+ appleGram+" - Toplam tutar: "+ appleTotalPrice+ "TL");
            //Console.WriteLine("Alınan Ürün: Portakal " + "Birim Fiyat: "+OrangePrice + " - Gramaj: "+ orangeGram+" - Toplam tutar: "+ orangeTotalPrice+ "TL");
            //Console.WriteLine("Alınan Ürün: Çilek " + "Birim Fiyat: "+StrawberryPrice + " - Gramaj: "+ strawberryGram+" - Toplam tutar: "+ strawberryTotalPrice+ "TL");
            //Console.WriteLine("Alınan Ürün: Patates " + "Birim Fiyat: "+PotatoPrice + " - Gramaj: "+ potatoGram+" - Toplam tutar: "+ potatoTotalPrice+ "TL");
            //Console.WriteLine("Alınan Ürün: Domates " + "Birim Fiyat: "+TomatoPrice + " - Gramaj: "+ tomatoGram+" - Toplam tutar: "+ tomatoTotalPrice+ "TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Topalam tutar:" + shoppingTotalPrice + " TL ");


            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //" '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);




            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("*** Csharp Hava yolları Yolcu Bilgisi ***");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine();



            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Bilgisi: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("---------------");
            //Console.WriteLine("Yolcu Kimlik Bilgisi: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " +passengerDistrict + " / " + passengerCity + " " + passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice=shoeCount*shoePrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);





            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 =double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3=double.Parse(Console.ReadLine());

            //result=(exam1+exam2+exam3) /3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+result);





            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            


            #endregion

            Console.Read();
        }
    }
}
