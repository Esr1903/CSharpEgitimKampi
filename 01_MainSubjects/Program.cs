using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları 
            /* Region ifadesini kullan sol taradta çıkan aşağı ok işaretini tıklayınca yazdırma komutlarını komple içine alır
            endregion ile de kapat.*/

            //Console.Write("Merhaba Dünya"); //Bir yapının metot olduğunu anlamak için s ol tarafına bak mor küp varsa metottur.
            //Metodun çıktıları alfabatik olarak yazılacaksa eğer çift tırnak sembolü içinde yazılır.
            //Her satır sonuna noktalı virgül koy.
            //Write ifadesi bir yazıyı yazdıktan sonra imlecio yazının en sonuna atar.
            //Console.WriteLine("Selam"); //Bir değer yazar sonra imeci alt satıra indirir.


            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();    //Bir satır daha boşluk bıraksın.
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");  //Ctrl+D yaparak bir satırı komple aşağı indirebilirsin yani kopyalyıp alta yapıştırır.
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Değişkenler

            //Veriler üzerinde işlemler yapabilmemi sağlayan ve geçici olarak RAMdetutulan proglama değerleridir.
            //Değişken_türü Değişken_adı;  şeklindde değişkenler yazılır.
            //1-String

            //string name;       //alfabetik türde verileri tutar. Burada name isminde bir değişken tanımladık.
            //name = "Esra";/*Name değişkenini çağırıp bu değişkene bir atama yaptık.Bu değeri RAM bellekte name isminde bir değişkende
            //                tutar.Ama bu değeri ekranda göstermek için de yazdırma komutu olan console.write kullan */
            //Console.Write(name); //Direkt değişkeni çağırdık tırnak içinde değil çünkü eğer " içinde yazsak ekrana name yazısını yazar

            //string customerName;   /*Değişken alandırırken kullanılan isim standartları vardır bunlardan birincisi camel casedir
            //     camel casede 1.harf küçük sonraki harfler küçük olur.Değişkenler adlandırılırken araya boşluk bırakılmaz.
            //    Altını kırmızı çizerse hata altını yeşil çizerse uyarıdır.*/
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city; //Bir satırda aynı türde birden fazla değişken tanımlanabilir.

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);//boşluk bırakmak için " " tırnak boşluk bıraktım.
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: Adresi: " + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);  //çift tırnakları birleştirmek için arada + kullan.
            //Console.WriteLine("-----------------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------");


            #endregion

            #region Int Değişkenler

            //integer tam sayı türündeki değişkenlerdir.
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");


            Console.WriteLine();    
            //bir müşterinin aldığı belli sayıda ürünleri hesaplayalım,kaç tane su içti gibi
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

            totalHamgurgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamgurgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamgurgerPrice + totalPizzaPrice + totalFriesPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
            #endregion
            Console.Read();
            //Read metodu ben enter tuşuna basana kadar konsol ekranını bekletecek olan komuttur yoksa ekran hemen kapanır.


        }
    }
}
