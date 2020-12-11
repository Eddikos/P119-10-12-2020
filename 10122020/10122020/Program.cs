using System;

namespace _10122020
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];

            //int[] numbers2 = { 12, 123, 34, 456, 5678 };

            //// Console.WriteLine(numbers[4]);

            //for (var i = 0; i < numbers2.Length; i++)
            //{
            //    //Console.WriteLine(numbers2[i]);
            //}

            //Console.WriteLine("Hello World!");

            //foreach (var item in numbers2)
            //{
            //    //Console.WriteLine(item);
            //}

            //string[] words = { "elovset", "ders", "bina", "xina", "horrible" };

            //foreach (var item in words)
            //{
            //    //Console.WriteLine("Prefix: " + item);
            //}

            //Array.Reverse(words);

            //foreach (var item in words)
            //{
            //    //Console.WriteLine("Prefix: " + item);
            //}








            //var otherWords = words;

            //Array.Sort(words);

            //foreach (var item in words)
            //{
            //    //Console.WriteLine("Prefix: " + item);
            //}

            //foreach (var item in otherWords)
            //{
            //    //Console.WriteLine("Prefix: " + item);
            //}

            //Console.WriteLine(Array.IndexOf(otherWords, "asdfghjkl"));

            //Array.Resize(ref otherWords, 2);
            
            //foreach (var item in otherWords)
            //{
            //    Console.WriteLine("Prefix: " + item);
            //}

            //Console.WriteLine("-----------------------------");

            //Array.Resize(ref otherWords, 10);

            //foreach (var item in otherWords)
            //{
            //    Console.WriteLine("Prefix: " + item);
            //}

            //otherWords[3] = "sasda";

            var mesut = new Student();
            mesut.Name = "Mesut";
            var cavid = new Student();
            cavid.Name = "Cavid";
            var sadiq = new Student();
            sadiq.Name = "Sadiq";
            var narmin = new Student();
            narmin.Name = "Narmin";

            Student[] arrayOfStudents = new Student[3];
            arrayOfStudents[0] = mesut;
            arrayOfStudents[1] = cavid;
            arrayOfStudents[2] = sadiq;

            Array.Resize(ref arrayOfStudents, arrayOfStudents.Length + 1);

            arrayOfStudents[arrayOfStudents.Length -1 ] = narmin;

            foreach (var student in arrayOfStudents)
            {
                Console.WriteLine(student.ReturnAge());
            }
        }

        public class Student
        { 
            public string Name { get; set; }

            public string ReturnAge()
            { 
                return Name + ": " + 15;
            }
        }
    }
}
