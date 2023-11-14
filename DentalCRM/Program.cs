using System;
using System.Collections.Generic;

class Program 
{
    static List<Patient> patients = new List<Patient>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Dental Clinic CRM");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. View Patients");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddPatient();
                    break;
                case "2":
                    ViewPatients();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddPatient()
    {
        Console.WriteLine("\nAdd a new patient:");

        Console.Write("Enter patient name: ");
        string name = Console.ReadLine();

        Console.Write("Enter patient age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter patient contact number: ");
        string contactNumber = Console.ReadLine();

        Patient newPatient = new Patient
        {
            Name = name,
            Age = age,
            ContactNumber = contactNumber
        };

        patients.Add(newPatient);

        Console.WriteLine("Patient added successfully!\n");
    }

    static void ViewPatients()
    {
        Console.WriteLine("\nList of Patients:");

        if (patients.Count == 0)
        {
            Console.WriteLine("No patients found.");
        }
        else
        {
            foreach (var patient in patients)
            {
                Console.WriteLine($"Name: {patient.Name}, Age: {patient.Age}, Contact Number: {patient.ContactNumber}");
            }
        }

        Console.WriteLine();
    }
}

class Patient
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string ContactNumber { get; set; }
}