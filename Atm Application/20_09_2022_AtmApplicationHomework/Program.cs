using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace _20_09_2022_AtmApplicationHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question

            // ATM uygulaması tasarlanacak. Kullanıcı Adı ve Şifre ile Giriş yapılacak. ATM'de para çekme, para yatırma, bakiye sorgulama, çıkış özellikleri gibi özellikler olacak.

            #endregion

            #region Answer

            Console.WriteLine();
            Console.WriteLine("****_________________________ATM UYGULAMASI_________________________****");
            //UserInformation (kullanıcı bilgileri)
            string name = "KEMAL";
            string surname = "EROL";
            // double[] identificationNumber = new double[11] { 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };     
            string identificationNumber = "88888888888";         //kimlik numarası
            string nameOfTheBank = "BRBCİGA BANK";
            string accountNumber = "1111111111111111";          //hesap numarası
            string ıban = "TR11 1111 1111 1111 1111111111";     //iban
            string password = "1234";
            double amountOfMoney = 80590;




            int attempt = 3;
            while (attempt > 0)
            {
                Console.WriteLine();
                Console.Write("TC KİMLİK NUMARASI: ");
                string identificationNumber1 = Console.ReadLine();
                Console.Write("ŞİFRE: ");
                string password1 = Console.ReadLine();

                if (identificationNumber1 == identificationNumber && password1 == password)
                {
                    Console.WriteLine("İŞLEM BAŞARILI");

                    Console.WriteLine();
                    Console.WriteLine("HESAP BİLGİLERİ: ");
                    Console.WriteLine("     KULLANICI ADI SOYADI: " + name + " " + surname);
                    Console.WriteLine("     TC KİMLİK NUMARASI: " + identificationNumber);
                    Console.WriteLine("     HESAP NUMARASI. " + accountNumber);
                    Console.WriteLine("     İBAN: " + ıban);
                    Console.WriteLine("     BAKİYE: " + amountOfMoney + " TL");

                    Console.WriteLine();
                    Console.WriteLine(     "İŞLEM EKRANI: ");
                    Console.WriteLine("     1.İŞLEM: PARA ÇEKME İŞLEMİ");
                    Console.WriteLine("     2.İŞLEM: PARA YATIRMA İŞLEMİ");
                    Console.WriteLine("     3.İŞLEM: PARA GÖNDERME İŞLEMİ");
                    //Console.WriteLine("4.İŞLEM: ÖDEME İŞLEMLERİ");







                    #region İŞLEM PANELİ


                    #region PARA ÇEKME İŞLEMİ
                    repeat:
                    yenişlem:
                    Console.WriteLine();
                    Console.Write("YAPMAK İSTEDİĞİNİZ İŞLEMİN SIRA NUMARASINI GİRİNİZ: ");
                    int selection = int.Parse(Console.ReadLine());

                    if (selection == 1)
                    {
                        Console.WriteLine("1.PARA ÇEKME İŞLEMİ:");
                        Console.WriteLine();
                        Console.WriteLine("     BAKİYE: " + amountOfMoney + " TL");
                        yenimiktar1:
                        Console.Write("     ÇEKMEK İSTEDİĞİNİZ MİKTARI GİRİNİZ: ");
                        double amount1 = double.Parse(Console.ReadLine());
                        if (amount1 <= amountOfMoney && amount1 % 5 == 0)
                        {
                            double newAmount1 = amountOfMoney - amount1;
                            Console.WriteLine();
                            Console.WriteLine("     İŞLEMİ TAMAMLAMAK İÇİN ENTER TUŞUNA BASINIZ.");
                            string enter2 = Console.ReadLine();
                            Console.WriteLine("     PARA ÇEKME İŞLEMİNİZ BAŞARILI.");
                            Console.WriteLine();
                            Console.WriteLine("BAKİYE: " + amountOfMoney + " TL");
                            Console.WriteLine("ÇEKTİĞİNİZ MİKTAR: " + amount1 + " TL");
                            Console.WriteLine("YENİ BAKİYENİZ: " + newAmount1);
                            
                            Console.WriteLine();
                            Console.Write("BAŞKA İŞLEM YAPMAK İSTİYOR MUSUNUZ? EVET İSE 'E', HAYIR İSE 'H' GİRİNİZ: ");
                            string newOperation = Console.ReadLine();
                            if (newOperation == "E")
                            {
                                goto yenişlem;
                            }
                            else if (newOperation == "H")
                            {
                                Console.WriteLine("ÇIKIŞ YAPILDI.");
                            }
                        }
                        else if (amount1 <= amountOfMoney && amount1 % 5 != 0)
                        {
                            Console.WriteLine("GEÇERSİZ BAKİYE.ÇEKMEK İSTEDİĞİNİZ MİKTARI GİRERKEN LÜTFEN 5'İN KATI OLMASINA DİKKAT EDİNİZ.");
                            goto yenimiktar1;
                        }
                        else if (amount1 > amountOfMoney)
                        {
                            Console.WriteLine("YETERSİZ BAKİYE.YENİ BİR MİKTAR GİRİNİZ.");
                            goto yenimiktar1;
                        }
                    }
                    #endregion







                    #region PARA YATIRMA İŞLEMİ

                    if (selection == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("2.PARA YATIRMA İŞLEMİ:");
                        Console.WriteLine("     BAKİYE: " + amountOfMoney + " TL");
                        Console.Write("     YATIRMAK İSTEDİĞİNİZ MİKTARI GİRİNİZ: ");
                        double amount2 = double.Parse(Console.ReadLine());

                        double newAmount2 = amountOfMoney + amount2;
                        Console.WriteLine("     İŞLEMİ TAMAMLAMAK İÇİN ENTER TUŞUNA BASINIZ.");
                        string enter3 = Console.ReadLine();

                        Console.WriteLine("     PARA YATIRMA İŞLEMİNİZ BAŞARILI.");
                        Console.WriteLine();
                        Console.WriteLine("BAKİYE: " + amountOfMoney + " TL");
                        Console.WriteLine("YATIRDIĞINIZ MİKTAR: " + amount2 + " TL");
                        Console.WriteLine("YENİ BAKİYENİZ: " + newAmount2 + " TL");
                        Console.WriteLine();
                        Console.Write("BAŞKA İŞLEM YAPMAK İSTİYOR MUSUNUZ? EVET İSE 'E', HAYIR İSE 'H' GİRİNİZ: ");
                        string newOperation = Console.ReadLine();
                        if (newOperation == "E")
                        {
                            goto yenişlem;
                        }
                        else if (newOperation == "H")
                        {
                            Console.WriteLine("ÇIKIŞ YAPILDI.");
                        }
                    }
                    #endregion


                    




                    #region PARA GÖNDERME İŞLEMİ
                    if (selection == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("2.PARA GÖNDERME İŞLEMİ:");
                        Console.WriteLine("     ALICININ BİLGİLERİ: ");
                        Console.Write("         ALICININ ADI SOYADI: ");
                        string recipientName = Console.ReadLine();
                        Console.Write("         ALICININ HESAP NUMARASI: ");
                        double accountNumber2 = double.Parse(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("         GÖNDERME SEÇENEĞİNİ SEÇİNİZ.");
                        Console.WriteLine("             1.HESAPTAN GÖNDERİM");
                        Console.WriteLine("             2.NAKİT GÖNDERİM");
                        Console.Write("                 İSTEDİĞİNİZ GÖNDERME SEÇENEĞİNİN NUMARASINI GİRİNİZ: ");
                        int selection1 = int.Parse(Console.ReadLine());

                        if (selection1 == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("HESAPTAN GÖNDERİM İŞLEMİ:");
                            Console.Write("     GÖNDERİLECEK MİKTARI GİRİNİZ: ");
                            double amount3 = double.Parse(Console.ReadLine());
                            double newAmount3 = amountOfMoney - amount3;
                            Console.WriteLine("     İŞLEMİ TAMAMLAMAK İÇİN ENTER TUŞUNA BASINIZ.");
                            string enter5 = Console.ReadLine();
                            Console.WriteLine("     PARA GÖNDERME İŞLEMİNİZ BAŞARILI.");
                            Console.WriteLine();
                            Console.WriteLine("BAKİYE: " + amountOfMoney + " TL");
                            Console.WriteLine("GÖNDERDİĞİNİZ MİKTAR: " + amount3 + " TL");
                            Console.WriteLine("YENİ BAKİYENİZ: " + newAmount3 + " TL");
                            Console.WriteLine();
                            Console.Write("BAŞKA İŞLEM YAPMAK İSTİYOR MUSUNUZ? EVET İSE 'E', HAYIR İSE 'H' GİRİNİZ: ");
                            string newOperation = Console.ReadLine();
                            if (newOperation == "E")
                            {
                                goto yenişlem;
                            }
                            else if (newOperation == "H")
                            {
                                Console.WriteLine("ÇIKIŞ YAPILDI.");
                            }
                        }
                        else if (selection1 == 2)
                        {
                            Console.WriteLine();
                            Console.WriteLine("     NAKİT GÖNDERİM İŞLEMİ:");
                            Console.WriteLine("     LÜTFEN GÖNDERECEĞİNİZ MİKTARIN 5'İN KATI OLMASINA DİKKAT EDİNİZ.");
                            Console.Write("         GÖNDERİLECEK MİKTARI GİRİNİZ: ");
                            double amount4 = double.Parse(Console.ReadLine());

                            Console.WriteLine();
                            Console.WriteLine("      İŞLEMİ TAMAMLAMAK İÇİN ENTER TUŞUNA BASINIZ.");
                            string enter4 = Console.ReadLine();
                            Console.WriteLine("      PARA GÖNDERME İŞLEMİNİZ BAŞARILI.");
                            Console.WriteLine();
                            Console.WriteLine("BAKİYE: " + amountOfMoney + " TL");
                            Console.WriteLine("GÖNDERDİĞİNİZ MİKTAR: " + amount4 + " TL");
                            Console.WriteLine("BAKİYENİZ: " + amountOfMoney + " TL");
                            Console.WriteLine();
                            Console.Write("BAŞKA İŞLEM YAPMAK İSTİYOR MUSUNUZ? EVET İSE 'E', HAYIR İSE 'H' GİRİNİZ: ");
                            string newOperation = Console.ReadLine();
                            if (newOperation == "E")
                            {
                                goto yenişlem;
                            }
                            else if (newOperation == "H")
                            {
                                Console.WriteLine("ÇIKIŞ YAPILDI.");
                            }
                        }

                    }
                    #endregion
                    else
                    {
                        Console.WriteLine("GEÇERSİZ İŞLEM.");
                       
                    }


                    break;
                    #endregion


                }
                else if (identificationNumber1 != identificationNumber || password1 != password)
                {

                    Console.WriteLine($"YANLIŞ BİLGİ GİRDİNİZ.BİLGİLERİNİZİ KONTROL EDEREK TEKRAR GİRİNİZ.KALAN DENEME HAKKINIZ: {attempt - 1}");
                    attempt--;

                    if (attempt == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("3 DEFA HATALI GİRİŞ YAPTINIZ. KARTINIZ BLOKE OLDU.");
                        break;
                       
                    }
                    
                }

                Console.WriteLine();
            }
           
            #endregion
        }
         
    }
}