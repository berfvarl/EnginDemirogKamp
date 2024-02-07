using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaraund
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //SelamVer("ali");n
            //SelamVer("ayşe");
            //SelamVer("engin");
            //SelamVer();
            //Topla(5, 10);

            ////Arrays 
            //string[] students = new string[3];
            //students[0] = "Engin";
            //students[1] = "kerem";
            //students[2] = "berkay";
            //Console.WriteLine("------Foreach------------");
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.WriteLine("------------For----------------");
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}
            //string[] sehirler1 =new[] {"Ankara","i","b" };
            //string[] sehirler2 = new[] { "b", "a", "d" };
            //sehirler2 = sehirler1;
            //sehirler1[0] = "adana";
            //Console.WriteLine(sehirler2[0]);
            //List<string> sehirler3 = new List<string>();
            //sehirler3.Add("urfa");
            //sehirler3.Add("aydın");
            //foreach (var i in sehirler3)
            //{
            //    Console.WriteLine(i);
            //}
            Person person1 = new Person();
            person1.FirstName = "Berfin";
            person1.LastName = "Varli";
            person1.DateOfBirthYear = 2002;
            person1.NationalIdentity = 12345678910;
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }
        //public static void SelamVer(string isim="")
        //{
        //    string mesaj = "helllo  "+isim;
        //    Console.WriteLine(mesaj);
        //}

        //static int Topla(int sayi1,int sayi2)
        //{
        //    int sonuc = sayi1 + sayi2;
        //    Console.WriteLine("Toplam :" + sonuc);
        //    return sonuc;
        //}
    }
}




