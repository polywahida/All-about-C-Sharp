using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Advance_Part2
{
    public class EventAndDelegate
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    public static void DelegateExample()
    {
        Person p1 = new Person() { Name = "Riyad", Age = 15 };
        Person p2 = new Person() { Name = "Labib", Age = 65 };
        Person p3 = new Person() { Name = "Poly", Age = 20 };
        Person p4 = new Person() { Name = "Adil", Age = 35 };

        List<Person> personList = new List<Person>() { p1, p2, p3, p4 };
        //anonymous
        FilterDelegate filter = delegate (Person person)
        {
            return person.Age >= 20 && person.Age <= 30;
        };
        DisplayPeople("Senior", personList, filter);

        //Lambda Expression
        (Person person) => { true; };
        string searchKeyword = "Poly";

        DisplayPeople("Age >= 20 with search keyword: " + searchKeyword, personList,(p) =>
        {
            if (p = null) return false;
            if(p.Name.Contains(searchKeyword)&& p.Age >= 20 && p.Age <=30)
            {
                return true;
             }
            return false;
        });


    };
    public static void DisplayPeople(string title,List<Person>,FilterDelegate filter)
    {
        Console.WriteLine(title);
        foreach (Person p in person)
        {
            if (filter(p))
            {
                Console.WriteLine("{0},{1} years old", p.Name, p.Age);

            }
    }
