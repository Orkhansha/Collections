using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = new List<int>();

            //nums.Add(5);
            //nums.Add(55);
            //nums.Add(52);
            //nums.Add(9);

            //List<string> str = new List<string>();

            //str.Add("Orxan");
            //str.Add("Emil");
            //str.Add("Togrul");
            //str.Add("Fidan");

            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //if (nums.Count == 4)
            //{
            //    Console.WriteLine("List count is {0}, elave reqem",nums.Count,15);
            //}


            //List<Person> people = new List<Person>();
            //Person person1 = new Person();
            //person1.Id = 5;
            //person1.Name = "Huseyn";
            //person1.Email = "huseyn@gmail.com";

            //Person person2 = new Person
            //{
            //    Id = 6,
            //    Name = "Ramil",
            //    Email = "ramil@gmail.com"
            //};

            //people.Add(person1);

            //people.Add(person2);

            //people.Add(new Person { Id = 1, Name = "Orxan", Email = "orxan@gmail.com" });
            //people.Add(new Person { Id = 7, Name = "Orxan", Email = "orxan1@gmail.com" });
            //people.Add(new Person { Id = 2, Name = "Emil", Email = "emil@gmail.com" });
            //people.Add(new Person { Id = 3, Name = "Fidan", Email = "fidan@gmail.com" });
            //people.Add(new Person { Id = 4, Name = "Seadet", Email = "seadet@gmail.com" });

            //Console.WriteLine(person2.Name);

            //GetStudents(people);

            //GetNumbers(nums);

            //var result = GetPersonByName(people, "Ramil");
            //Console.WriteLine(result.Name + "-" + result.Id + "-" +result.Email);

            //var result = GetPeopleByName(people, "Orxan"); 


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name + "-" + item.Id + "-" + item.Email);
            //}


            //Hashtable datas = new Hashtable();
            //datas.Add(1, "Togrul");
            //datas.Add(2, "Orxan");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}


            //SortedList datas = new SortedList();
            //datas.Add(1, "Seid");
            //datas.Add(2, "Mustafa");
            //datas.Add(3, "Hesenagha");
            //datas.Add(4, "Gulbala");

            //foreach (DictionaryEntry item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}

            //SortedList<int, string> datas = new SortedList<int, string>();
            //datas.Add(4, "Huseyn");
            //datas.Add(7, "Memmed");

            //foreach (KeyValuePair<int,string> item in datas)
            //{
            //    Console.WriteLine(item.Key + "-" + item.Value);
            //}

            //ArrayList datas = new ArrayList();
            //datas.Add("Salam");
            //datas.Add(7);
            //datas.Add(true);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //HashSet<int> datas = new HashSet<int>();
            //datas.Add(3);
            //datas.Add(7);
            //datas.Add(3);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> datas = new Stack<int>();

            //datas.Push(5);
            //datas.Push(22);
            //datas.Push(18);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}


            //Queue<int> datas = new Queue<int>();
            //datas.Enqueue(5);
            //datas.Enqueue(22);
            //datas.Enqueue(18);

            //foreach (var item in datas)
            //{
            //    Console.WriteLine(item);
            //}



            //Dictionary<string, string> datas = new Dictionary<string, string>();
            //datas.Add("Super admin", "Cavid");
            //datas.Add("Admin", "Orxan");
            //datas.Add("Member", "Mirsamir");
            //datas.Add("Test", "Orxan");

            //foreach (var item in datas)
            //{
            //    if (item.Key == "Admin")
            //    {
            //        Console.WriteLine($"Name : {item.Value}, Role : {item.Key}");
            //        break;
            //    }
            //}





        }

        public static Person GetPersonByName(List<Person> people, string name)
        {
            var person = people.Find(m => m.Name == name);
            return (person);
        }

        public static List<Person> GetPeopleByName(List<Person> people, string name)
        {
            var persons = people.FindAll(m => m.Name == name);
            return (persons);
        }

        public static void GetStudents(List<Person> students)
        {
            foreach (var stu in students)
            {
                Console.WriteLine("Students : Id - {0}, Name - {1}, Email - {2}", stu.Id, stu.Name, stu.Email);
            }
        }

        public static void GetNumbers(List<int> nums)
        {
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }

    }
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
