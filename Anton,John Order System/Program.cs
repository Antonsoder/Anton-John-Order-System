using System;
using System.Collections.Generic;
using System.Text;

namespace Anton_John_Order_System
{

    class Program
    {
        static void Main(string[] args)
        {
            bool pProgram = true;
            Amazon amazon = new Amazon(1, "AmazoneAntJohn");
            Administrator admin1 = new Administrator("John", "John@Gmail.com");
            amazon.aAdministrator.Add(admin1);
            Console.WriteLine("hejsan");

            while (pProgram == true)
            {
                Console.WriteLine("vill du vara \n 1. Administrator \n 2. Customer");
                int hejsan = int.Parse(Console.ReadLine());
                switch (hejsan)
                {
                    case 1:
                        Console.WriteLine(" Vill du skapa en admin 1. \n eller interagera 2.");
                        hejsan = int.Parse(Console.ReadLine());
                        switch (hejsan)
                        {
                            case 1:
                                Console.WriteLine("Skriv dina uppgifter så här namn och sedan Email: ");
                                string namn = Console.ReadLine();
                                string Email = Console.ReadLine();
                                Administrator admin = new Administrator(namn, Email);
                                amazon.aAdministrator.Add(admin);
                                foreach (var Administrator in amazon.aAdministrator)
                                {
                                    Console.WriteLine(Administrator.AdminName);
                                    Console.WriteLine(Administrator.AdminEmail);
                                    Console.WriteLine("----------------------");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Ok vill du handla in 1. Äpple \n 2. Iphone \n 3. Dator");
                                hejsan = int.Parse(Console.ReadLine());
                                switch (hejsan)
                                {
                                    case 1:
                                        Console.WriteLine("Skriv description, värde och mängd");
                                        string Underlag = Console.ReadLine();
                                        int värde = int.Parse(Console.ReadLine());
                                        int antal = int.Parse(Console.ReadLine());
                                        Äpple äpple = new Äpple(Underlag, värde, antal);
                                        admin1.aÄpple.Add(äpple);
                                        foreach (var aäpple in admin1.aÄpple)
                                        {
                                            Console.WriteLine(aäpple.Discription);
                                            Console.WriteLine(aäpple.Value);
                                            Console.WriteLine(aäpple.AmountOf);
                                            Console.WriteLine("------------------");
                                        }
                                        break;
                                    case 2:
                                        Console.WriteLine("Skriv description, värde och mängd");
                                        string Underlag1 = Console.ReadLine();
                                        int värde1 = int.Parse(Console.ReadLine());
                                        int antal1 = int.Parse(Console.ReadLine());
                                        Iphone iphone = new Iphone(Underlag1, värde1, antal1);
                                        admin1.aIphone.Add(iphone);
                                        foreach (var aiphone in admin1.aIphone)
                                        {
                                            Console.WriteLine(aiphone.Discription);
                                            Console.WriteLine(aiphone.Value);
                                            Console.WriteLine(aiphone.AmountOf);
                                            Console.WriteLine("------------------");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Skriv description, värde och mängd");
                                        string Underlag2 = Console.ReadLine();
                                        int värde2 = int.Parse(Console.ReadLine());
                                        int antal2 = int.Parse(Console.ReadLine());
                                        Dator dator = new Dator(Underlag2, värde2, antal2);
                                        admin1.aDator.Add(dator);
                                        foreach (var adator in admin1.aDator)
                                        {
                                            Console.WriteLine(adator.Discription);
                                            Console.WriteLine(adator.Value);
                                            Console.WriteLine(adator.AmountOf);
                                            Console.WriteLine("------------------");
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Skall det vara \n1. Skapa costumer \n2. handla som en costumer");
                        hejsan = int.Parse(Console.ReadLine());
                        switch(hejsan)
                        {
                            case 1:
                                Console.WriteLine("Skriv dina uppgifter i denna ordning: namn, adress, email och kredikortnummer");
                                string namn = Console.ReadLine();
                                string adress = Console.ReadLine();
                                string email = Console.ReadLine();
                                string kreditkort = Console.ReadLine();
                                string användarnamn = Console.ReadLine();
                                string lösen = Console.ReadLine();
                                Customer customer = new Customer(namn, adress, email, kreditkort, användarnamn, lösen);
                                amazon.aCustomers.Add(customer);
                                Console.WriteLine("Du har nu gjort din costumer! Dessa är vilka som finns");
                                foreach (var acustom in amazon.aCustomers)
                                {
                                    Console.WriteLine(acustom.CustomerName);
                                    Console.WriteLine(acustom.Address);
                                    Console.WriteLine(acustom.Email);
                                    Console.WriteLine(acustom.CreditCardInfo);
                                    Console.WriteLine(acustom.användarNamn);
                                    Console.WriteLine(acustom.lösenord);
                                    Console.WriteLine("-------------------------");
                                }
                                break;
                            case 2:
                                Console.WriteLine("Du måste identifiera dig innan du kan handla, skriv ditt användarnamn och lösenord");
                                användarnamn = Console.ReadLine();
                                lösen = Console.ReadLine();
                                foreach (var acustom in amazon.aCustomers)
                                {
                                    if (användarnamn == acustom.användarNamn && lösen == acustom.lösenord)
                                    {
                                        Console.WriteLine($"välkomen {användarnamn} eller {acustom.CustomerName}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Fel användarnamn eller lösenord");
                                    }
                                }
                                Console.WriteLine("vad vill du handla \n1. Dator \n2.Iphone \n3. Äpple");
                                hejsan = int.Parse(Console.ReadLine());
                                switch (hejsan)
                                {
                                    case 1:
                                        Console.WriteLine("Hur många Datorer vill du ha?");
                                        int antal = int.Parse(Console.ReadLine());
                                        foreach (var adator in admin1.aDator)
                                        {
                                            adator.AmountOf = adator.AmountOf - antal;
                                            Console.WriteLine($"Du köpte {antal} äpple därmed finns det bara kvar {adator.AmountOf} Detta kostade {adator.Value}");
                                        }
                                        break;
                                    case 2:
                                        Console.WriteLine("Hur många Iphones vill du ha?");
                                        antal = int.Parse(Console.ReadLine());
                                        foreach (var aIphone in admin1.aIphone)
                                        {
                                            aIphone.AmountOf = aIphone.AmountOf - antal;
                                            Console.WriteLine($"Du köpte {antal} äpple därmed finns det bara kvar {aIphone.AmountOf} Detta kostade {aIphone.Value}");
                                        }
                                        break;
                                    case 3:
                                        Console.WriteLine("Hur många Äpplen vill du ha?");
                                        antal = int.Parse(Console.ReadLine());
                                        foreach (var aÄpple in admin1.aÄpple)
                                        {
                                            aÄpple.AmountOf = aÄpple.AmountOf - antal;
                                            Console.WriteLine($"Du köpte {antal} äpple därmed finns det bara kvar {aÄpple.AmountOf} Detta kostade {aÄpple.Value}");
                                        }
                                        break;
                                }
                                break;
                        }

                        break;

                }
            }
        }
    }
}