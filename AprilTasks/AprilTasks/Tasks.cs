using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprilTasks
{
    class Tasks
    {
        public static void Task1()
        {
            int num1 = 5;
            int num2 = 10;
            Console.WriteLine(num1+num2);

            //alternativ sum = num1+num2 cw(sum)
        }
        public static void Task2()
        {
            int num = 5;
            //double kvadrati = Math.Pow(num,2);
            int kvadrati = num * num;
            Console.WriteLine(kvadrati);
        }
        public static void Task3()
        {
            string name = "Sabir";
            int age = 20;// Teesufki

            Console.WriteLine($"Salam Menim Adim {name} ve {age} yasim var");
        }
        public static void Task4()
        {
            int a = 10;
            int b = 20;

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"a deyiseninin evvelki deyeri {b} indiki deyeri {a}");
            Console.WriteLine($"b deyiseninin evvelki deyeri{a} indiki deyeri {b} ");
        }
        public static void Task5()
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 35;

            int sum = num1 + num2 + num3;
            int edediOrta = sum / 3;
            Console.WriteLine($"Verilmis Ededlerin cemi {sum}");
            Console.WriteLine($"Verilmis ededlerin ededi ortasi {edediOrta}");
        }
        public static void Task6()
        {
            int num = 1234;
            int qaliq;
            int sum = 0;
            while(num != 0)
            {
                qaliq = num % 10;
                sum += qaliq;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
        public static void Task7()
        {
            int num = 0;

            if (num % 2 == 0)
            {
                Console.WriteLine("Verilmis Eded cutdur");
            }
            else
            {
                Console.WriteLine("Verilmis Eded Tekdir");
            }
        }
        public static void Task8()
        {
            int num1 = 7;
            int num2 = 10;

            if(num1 > num2)
            {
                Console.WriteLine("Birinci Eded Boyukdur");
            }
            else if ( num1 < num2)
            {
                Console.WriteLine("Ikinci Eded Boyukdur");
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Ededler Beraberdir");
            }
        }
        public static void Task9()
        {
            int num1 = -3;
            if(num1 > 0)
            {
                Console.WriteLine("Reqem 0 Dan boyukdur. Yeni Musbetdir");
            }
            else if(num1 < 0)
            {
                Console.WriteLine("Reqem 0 Dan Kicikdir. Yeni Menfidir");
            }
            else if(num1 == 0)
            {
                Console.WriteLine("Kandirildik Reqem 0 in ozudu");
            }
        }
        public static void Task10()
        {
            int num = 15;
            if(num %3==0 && num % 5 ==0)
            {
                Console.WriteLine("Tebrikler hem 3 e Hem 5 e qaliqsiz bolunen bir eded tapdiniz!");
            }
            else
            {
                Console.WriteLine("Teesufki Bu Reqem Meyarlara uygun gelmir");
            }
        }
        public static void Task11()
        {
            int num = 23;
            if (num % 3 == 0 && num % 2 == 0)
            {
                Console.WriteLine("Tebrikler hem 3 e Hem 2 e qaliqsiz bolunen bir eded tapdiniz!");
            }
            else
            {
                Console.WriteLine("Teesufki Bu Reqem Meyarlara uygun gelmir");
            }
        }

        public static void Task12()
        {
            int num = 15;

            switch (num)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("Febuary");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Zehmet Olmasa 1 ile 12 arasinda bir reqem daxil edin");
                    break;

            }
        }

        public static void Task13()
        {
            int bal = 14;

            switch (bal)
            {
                case <0:
                    Console.WriteLine("Baliniz 0 olabilmez");
                    break;
                case  0:
                    Console.WriteLine("Sizin Pravanizin Siftesi Olmayib");
                    break;
                case > 0 and < 5:
                    Console.WriteLine("Sifetini Elemisiniz Xeyirli Olsun");
                    break;
                case > 5 and < 10:
                    Console.WriteLine("Yavas Yavas Avtobus Yolu");
                    break;
                case > 10 and < 15:
                    Console.WriteLine("Ehtiyatli olmaq Lazimdir");
                    break;
                case > 15 and < 19:
                    Console.WriteLine("Sona Yaxinlasiriq");
                    break;
                case 20:
                    Console.WriteLine("Artiq Pravaniz yoxdur uhm 1200 manat uhm");
                    break;
                    
            }
        }

        public static void Task14()
        {
            int num1 = 5;
            int num2 = 10;
            char operation = '+';
            switch (operation)
            {
                case '+':
                    Console.WriteLine(num1 +num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '/':
                    Console.WriteLine(num1/num2);
                    break;
                case '*':
                    Console.WriteLine(num1*num2);
                    break;
            }

        }

        public static  void Task15()
        {
            double qiymet = 120; //Faizler ile isleyende . olma ehtimali coxdur ona gore int yerine float veya double istifade etdim
            double endirimliQiymet;
            double faizQiymet;
            if(qiymet >= 100)
            {
                if(qiymet > 100)
                {
                    faizQiymet = qiymet * 0.1;
                    endirimliQiymet = qiymet - faizQiymet;
                }
                else if (qiymet > 49 && qiymet < 99)
                {
                    faizQiymet =qiymet * 0.05;
                    endirimliQiymet = qiymet - faizQiymet;
                }
                else if(qiymet < 50)
                {
                    Console.WriteLine("Endirim yoxdur di sagol");
                }
            }
        }

        public static void Task16()
        {
            string userName = "admin";
            string userPassword = "2222"; //string olaraq qeyd etmeyimin sebebi adi hallarda passwordlarda herfde qeyd olunur.
            Console.WriteLine("zehmet olmasa istifadeci adi qeyd edin");
            string inputName = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa parol daxil edin");
            string inputPassword = Console.ReadLine();

            if(inputName == userName && userPassword == inputPassword)
            {
                Console.WriteLine("Tebrikler Admin Panele Girdiniz");
            }
            else
            {
                Console.WriteLine("Istifadeci adi ve ya Parol Yanlisdir");
            }
        }

        public static void Task17()
    
        {
            Console.WriteLine("Salam Hansi Valyutadan digerine cevirmek istediyinizi qeyd edin AZN/USD");
            string input = Console.ReadLine();
            double cevrilmisMezenne;
            if(input == "AZN")
            {
                Console.WriteLine("Cevirmek istediyiniz Manati Daxil edin");
                double pul = double.Parse(Console.ReadLine());
                cevrilmisMezenne = pul * 0.59;
            }
            else if(input == "USD")
            {
                double pul = double.Parse(Console.ReadLine());
                cevrilmisMezenne = pul * 1.7;
            }
        }

        public static void Task18()
        {
            Console.WriteLine("Boyunuzu Daxil Edin");
            double boyu = double.Parse(Console.ReadLine());
            Console.WriteLine("Cekinizi Daxil Edin");
            double ceki = double.Parse(Console.ReadLine());
            double BMI = ceki / Math.Pow(boyu, 2);
            Console.WriteLine(BMI);
            if (BMI>= 30)
            {
                Console.WriteLine("Piylenme");
            }
            else if (BMI >= 25)
            {
                Console.WriteLine("Artiq Ceki");
            }
            else if (BMI >= 18.5)
            {
                Console.WriteLine("Normal Ceki");
            }
            else if (BMI > 0)
            {
                Console.WriteLine("Ceki azligi");
            }
        }

        public static void Task19()
        {
            double mebleg = 237.47;
            Console.WriteLine("""
                 Etmek istediyiniz emeliyati qeyd edin
                1.Balansi Yoxlamaq
                2.Pul Elave Etmek
                3.Pul cixarmaq
                """);
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hal Hazirdaki Mebleg: " + mebleg);
                    break;
                case 2:
                    mebleg += double.Parse(Console.ReadLine());
                    Console.WriteLine("Yeni Mebleginiz" + mebleg);
                    break;
                case 3:
                    mebleg -= double.Parse(Console.ReadLine());
                    Console.WriteLine("Yeni Mebleginiz" + mebleg);
                    break;
            }
        }

        public static void Task20()
        {
            int[] array = {1,5,7,8,3,4,2};

            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
        public static void Task21()
        {
            int sum = 0;
            int[] arr = { 1, 5, 82, 4, 63, 45 };

            foreach (int num in arr)
            {
                sum += num;
            }
        }
        public static void Task22()
        {
            int[] arr = { 1, 5, 7, 3, 2, 4 };
            int sum = 0;
            int count = 0;

            foreach (var item in arr) //budefede var ile yazdim
            {

                sum += item;
                count++;
            }
            Console.WriteLine(sum/count);
        }

        public static void Task23()
        {
            int[] arr = { 1, 5, 7, 14, 19, 29 };
            Array.Sort(arr);
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[arr.Length-1]);
        }
        public static void Task24()
        {
            int[] arr = { 3, 6, 2, 5, 15, 67, 44, 32 }; //Muellim Allahaqqi arraya ne reqemler atim uje bilmirem
            foreach (var item in arr) 
            {
                if(item %2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void Task25()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] reversedArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                reversedArray[i] = arr[arr.Length - 1 - i];
            }
        }

        public static void Task26()
        {

            int[] nums = { 2, 3, 73, 45, 6, 1, 95, 43 };
            int yoxlanilasiEded = int.Parse(Console.ReadLine());
            foreach(int num in nums)
            {
                if (num == yoxlanilasiEded)
                {
                    Console.WriteLine(Array.IndexOf(nums, num));
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }
        }

        public static void Task27()
        {
            int[] nums = { 1, 5, 3, 7, 1, 8, 5 };
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1;j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {

                    Console.WriteLine(nums[i]);
                    }
                   
                }
            }
        }

        public static void Task28()
        {
            int[] arr = { 3, 632, 34, 2, 36, 86 };
            Array.Sort(arr);
            Console.WriteLine(arr.Length-2); 
            //Eyni zamanda for loopuna salib en birincini en kicik olaraq qeyd edib 
            //Compare ederekde tapmaq olar
        }
        public static void Task29()
        {
            int n = 231;
            int qaliq = 0;
            int sum = 0;
            while(n != 0)
            {
                qaliq = n % 10;
                sum += qaliq;
                n /= 10;
            }
            Console.WriteLine(sum);
        }
        public static void Task30()
        {
            int n = 1234;
            int count = 0;
            while (n != 0)
            {
                n /= 10;
                count++;
            }
            Console.WriteLine(count);
        }
        public static void Task31()
        {
            int eded = 17;
            bool murekkebEdeddir = false;
            for (int i = 2; i < eded; i++)
            {
                if (eded % i == 0)
                {
                    murekkebEdeddir = true;
                    break;
                }
            }
            Console.WriteLine(murekkebEdeddir ? "murekkebdir" : "sadedir");

        }
        public static void Task32()
        {
            int n = 121;
            int TempN = n;
            int qaliq = 0;
            int palindrome = 0;
            while (TempN != 0)
            {
                qaliq = TempN % 10;
                palindrome = palindrome * 10 + qaliq;
                TempN /= 10;
            }
            if (n == palindrome)
            {
                Console.WriteLine("Palindrome Dur");
            }
            else
            {
                Console.WriteLine("Palindrome Deyil ");
            }

        }
        public static void Task33()
        {
            int uzunluq = 10; 
            int a = 0;
            int b = 1;

            Console.WriteLine("Fibonacci Seriyasi:");

            for (int i = 0; i < uzunluq; i++)
            {
                Console.WriteLine(a);
                int temp = a + b;
                a = b;
                b = temp;
            }
        }
                

        
            
    }
}
