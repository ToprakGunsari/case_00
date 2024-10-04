using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Varibles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişken

            //double number;

            //number = 4.45;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi*****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.90;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("---- Elma Birim Fiyat: " + applePrice + " TL ");
            //Console.WriteLine("---- Portakal Birim Fiyat: " + orangePrice + " TL ");
            //Console.WriteLine("---- Çilek Birim Fiyat: " + strawberryPrice + "TL");
            //Console.WriteLine("---- Patetes Birim Fiyat: " + potatoPrice + " TL ");
            //Console.WriteLine("---- Domates Birim Fiyat: " + tomatoPrice + " TL ");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + "- Gramaj: " + appleGram + " Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün Portakal - " + "Birim Fİyat: " + orangePrice + "-Gramaj: " + orangeGram + " Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün Çilek - " + "Birim Fİyat: " + strawberryPrice + "-Gramaj: " + strawberryGram + " Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün Patates - " + "Birim Fİyat: " + potatoPrice + "-Gramaj: " + potatoGram + " Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün Domates - " + "Birim Fİyat: " + tomatoPrice + "-Gramaj: " + tomatoGram + " Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + " TL ");

            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //"   '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Klevyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentyNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimliği: ");
            //passengerIdentyNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------");
            //Console.WriteLine("Yolcu TC Kimlik: " + passengerIdentyNumber + "Yolcu Ad Soyad:  " + passengerName + "  " + passengerSurname + " " + passengerDistrict + 
            //    " / " + passengerCity + " " + passengerAge);


            //Console.WriteLine();





            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri

            //ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısnın Giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldğınız Televizyon Sayısını Girinzi: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplan Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlermleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Lütfen 1. Sınav Notunuzu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. Sınav Notunuzu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3. Sınav Notunuzu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavye Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz");
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("Seçtiğiniz Cinsiyet: " + gender);


            #endregion

            Console.Read();
        }
    }
}
