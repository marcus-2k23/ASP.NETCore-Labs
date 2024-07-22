namespace _8829569_LAB6;

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


class Program
{
    static List<Person> personList = new List<Person>();

    static void AddPerson()
    {
        Console.WriteLine("First Name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Last Name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter Birthdate");
        string birthdate = Console.ReadLine();
        Console.WriteLine("Address:");
        string address = Console.ReadLine();
        Console.WriteLine("City:");
        string city = Console.ReadLine();
        Console.WriteLine("Country:");
        string country = Console.ReadLine();
        Console.WriteLine("Province:");
        string province = Console.ReadLine();

        Person person = new Person
        {
            FirstName = firstName,
            LastName = lastName,
            Birthdate = birthdate,
            Address = address,
            City = city,
            Country = country,
            Province = province
        };

        personList.Add(person);
        Console.WriteLine("Person added");
    }


    static void ListPeople(){
        foreach (var person in personList)
        {
            Console.WriteLine($"{person.FirstName} ,{person.LastName}, {person.Birthdate} , {person.Address} , {person.City} , {person.Province} , {person.Country} \n ");
        }
    }

    static void SaveList()
    {
        string jsonDataFile = JsonConvert.SerializeObject(personList, Formatting.Indented);
        File.WriteAllText("person_list.json", jsonDataFile);
        Console.WriteLine("List saved");
    }

    static void LoadList()
    {
        try
        {
            string jsonDataFile = File.ReadAllText("person_list.json");
            personList = JsonConvert.DeserializeObject<List<Person>>(jsonDataFile);
            Console.WriteLine("List loaded");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No saved info found. creating a new one");
            personList = new List<Person>();
        }
    }

    
    static void Main()
    {
        LoadList();

        string input = "";

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("Type 1 to Add Person");
            Console.WriteLine("Type 2 to List People");
            Console.WriteLine("Type 3 to Save List");
            Console.WriteLine("Type 4 to Load List");
            Console.WriteLine("Type 5 to Exit");

            Console.Write("Enter a menu item: ");
            input = Console.ReadLine();

            if (input == "1"){
                 AddPerson();
            }
            if (input == "2"){
                 ListPeople();
            }
            if (input == "3"){
                SaveList();
            }
            if (input == "4"){
                LoadList();
            }
            if (input == "5"){
                return;
            }
            else{
                Console.WriteLine("Invalid input, please try again");
            }

            
        }
        while((input != "5"));
    }

}
