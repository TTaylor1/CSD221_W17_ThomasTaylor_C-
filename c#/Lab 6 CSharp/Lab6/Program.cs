using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Program
    {
        static List<Magazine> Mags = new List<Magazine>();
        static List<Book> Books = new List<Book>();
        static List<Publication> list = new List<Publication>();
        static List<Ticket> Tickz = new List<Ticket>();
        
        
        static void Main(string[] args)
        {
           
            CashTill Sales = new CashTill();

            Book book = new Book();
            book.Author = "Thomas Taylor";
            book.Title = "Java";
            book.Copies = 12;
            book.Price = 100;

            Book book1 = new Book();
            book1.Author = "Thomas Taylor jr";
            book1.Title = "Linux";
            book1.Copies = 12;
            book1.Price = 100;
            
            
            Magazine mag = new Magazine();
            mag.Title = "Yessir";
            mag.OrderQty = 10;
            mag.Price = 19.99;         
            mag.CurrIssue = "08-2017";

            Magazine mag1 = new Magazine();
            mag1.Title = "Yesmaam";
            mag1.OrderQty = 10;
            mag1.Price = 19.99;

            Books.Add(book);
            Books.Add(book1);
            Mags.Add(mag);
            Mags.Add(mag1);

            int choice = -1;
            int choice1 = -1;
            string Pub;
            
            

            while (choice < 0) {
                Console.Write("--------Main--------" +
                              "\n1. Books" +
                              "\n2. Magazines" +
                              "\n3. Tickets" +
                              "\n4. Checkout" +
                              "\n5. Exit \n");                
                choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n1. Add A Book" +
                                          "\n2. Edit A Book" +
                                          "\n3. Delete A Book" +
                                          "\n4. Sell A Book" +
                                          "\n5. Return to Main Menu" +
                                          "\n What would you like to do?");
                        choice1 = Convert.ToInt32(Console.ReadLine());

                        Pub = "Book";
                    do{
                     // switch statement to control which option the user chooses.
                    switch(choice1){
                    case 1:
                        choice = Add(choice1, Pub);
                        break;
                    case 2:
                        choice = Edit(choice1, Pub);  
                        break;
                    case 3:
                        choice = Delete(choice1, Pub);
                        break;
                    case 4:
                        choice = Sell(choice1, Pub, Sales);
                        break;
                    case 5: break;
                    }}while (choice != -1);
                    break;

                    case 2:
                        Console.WriteLine("\n1. Add A Magazine" +
                                          "\n2. Edit A Magazine" +
                                          "\n3. Delete A Magazine" +
                                          "\n4. Sell A Magazine" +
                                          "\n5. Return to Main Menu" +
                                          "\n What would you like to do?");
                        choice1 = Convert.ToInt32(Console.ReadLine());

                        Pub = "Magazine";
                    do{
                     // switch statement to control which option the user chooses.
                    switch(choice1){
                    case 1:
                        choice = Add(choice1, Pub);
                        break;
                    case 2:
                        choice = Edit(choice1, Pub);  
                        break;
                    case 3:
                        choice = Delete(choice1, Pub);
                        break;
                    case 4:
                        choice = Sell(choice1, Pub, Sales);
                        break;
                    case 5: break;
                    }}while (choice != -1);
                        break;

                    case 3:
                        Console.WriteLine("\n1. Add A Ticket" +
                                          "\n2. Edit A Ticket" +
                                          "\n3. Delete A Ticket" +
                                          "\n4. Sell A Ticket" +
                                          "\n5. Return to Main Menu" +
                                          "\n What would you like to do?");
                        choice1 = Convert.ToInt32(Console.ReadLine());

                        Pub = "Ticket";
                    do{
                     // switch statement to control which option the user chooses.
                    switch(choice1){
                    case 1:
                        choice = Add(choice1, Pub);
                        break;
                    case 2:
                        choice = Edit(choice1, Pub);  
                        break;
                    case 3:
                        choice = Delete(choice1, Pub);
                        break;
                    case 4:
                        choice = Sell(choice1, Pub, Sales);
                        break;
                    case 5: break;
                    }}while (choice != -1);
                        break;
                    case 4:
                        Console.WriteLine("Currently out of order");
                        break;

                    case 5: break;
                }

                
            }
        }


            static int Add(int choice, string Pub){

                Book bookz = new Book();
                Magazine mag = new Magazine();
                Ticket tick = new Ticket();
                
                
                if (Pub == "Book")
                {
                    Console.WriteLine("Title: ");
                    bookz.Title = Console.ReadLine();
                    Console.WriteLine("Quantity to Order: ");
                    bookz.Copies = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Price: ");
                    bookz.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Author: ");
                    bookz.Author = Console.ReadLine();

                    Books.Add(bookz);
                }

                else if (Pub == "Magazine")
                {
                    Console.WriteLine("Title: ");
                    mag.Title = Console.ReadLine();
                    Console.WriteLine("Quantity to Order: ");
                    mag.Copies = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Price: ");
                    mag.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Date of Current Issue: ");
                    mag.CurrIssue = Console.ReadLine();

                    Mags.Add(mag);
                }

                else if (Pub == "Ticket")
                {
                    Console.WriteLine("Description: ");
                    tick.Description = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    tick.Price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Client: ");
                    tick.Client = Console.ReadLine();

                    Tickz.Add(tick);
                }

                return choice = -1;
            }

            static int Edit(int choice, string Pub)
            {
                int counter = 0;
                int change = 0;

                Console.WriteLine("Here are the " + Pub + "'s currently in the system:");
                if (Pub == "Book")
                {
                    if (Books.Count < 1)
                    {
                        Console.WriteLine("There are currently no Books in the System.");
                        return choice = -1;
                    }
                    for (counter = 0; counter < Books.Count; counter++)
                    {
                        Console.WriteLine("\n" + ((counter + 1) + ". ") + Books[counter].Title);
                    }
                    Console.WriteLine("\n Choose which book you would like to edit: ");
                    counter = Convert.ToInt32(Console.ReadLine());
                    while (change > -1){
                    Console.WriteLine("\n Choose which section you would like to edit:"
                                  + "\n1. Edit the Title"
                                  + "\n2. Edit the Order Quantity"
                                  + "\n3. Edit the Price"
                                  + "\n4. Edit the Author "
                                  + "\n5. Return to Menu\n");
                    change = Convert.ToInt32(Console.ReadLine());
                    
                    
                        switch (change)
                        {
                            case 1:
                                Console.WriteLine("\n Edit the Title: ");
                                Books[counter - 1].Title = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("\nEdit the Order Quantity: ");
                                Books[counter - 1].Copies = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("\nEdit the Price: ");
                                Books[counter - 1].Price = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 4:
                                Console.WriteLine("\nEdit the Author: ");
                                Books[counter - 1].Author = Console.ReadLine();
                                break;
                            case 5:
                                change = -1;
                                break;
                        }
                    }

                }
                else if (Pub == "Magazine")
                {
                    if (Mags.Count < 1)
                    {
                        Console.WriteLine("There are currently no Magazines in the System.");
                        return choice = -1;
                    }

                    for (counter = 0; counter < Mags.Count; counter++)
                    {
                        Console.WriteLine("\n" + ((counter + 1) + ". ") + Mags[counter].Title);
                    }
                    Console.WriteLine("\n Choose which book you would like to edit: ");
                    counter = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n Choose which section you would like to edit:"
                                  + "\n1. Edit the Title"
                                  + "\n2. Edit the Order Quantity"
                                  + "\n3. Edit the Price"
                                  + "\n4. Edit the Author "
                                  + "\n5. Return to Menu\n");
                    change = Convert.ToInt32(Console.ReadLine());
                    switch (change)
                    {
                        case 1:
                            Console.WriteLine("\n Edit the Title: ");
                            Mags[counter - 1].Title = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("\nEdit the Order Quantity: ");
                            Mags[counter - 1].OrderQty = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("\nEdit the Price: ");
                            Mags[counter - 1].Price = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("\nEdit the Current Issue: ");
                            Mags[counter - 1].CurrIssue = Console.ReadLine();
                            break;
                        case 5: break;
                    }
                }
                else if (Pub == "Ticket")
                {
                    if (Tickz.Count < 1)
                    {
                        Console.WriteLine("There are currently no Tickets in the System.");
                        return choice = -1;
                    }

                    for (counter = 0; counter < Tickz.Count; counter++)
                    {
                        Console.WriteLine("\n" + ((counter + 1) + ". ") + Tickz[counter].Description);
                    }
                    Console.WriteLine("\n Choose which ticket you would like to edit: ");
                    counter = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n Choose which section you would like to edit:"
                                  + "\n1. Edit the Description"
                                  + "\n2. Edit the Price"
                                  + "\n3. Edit the Client "
                                  + "\n4. Return to Menu\n");
                    change = Convert.ToInt32(Console.ReadLine());
                    switch (change)
                    {
                        case 1:
                            Console.WriteLine("\n Edit the Title: ");
                            Tickz[counter - 1].Description = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("\nEdit the Price: ");
                            Tickz[counter - 1].Price = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("\nEdit the Client: ");
                            Tickz[counter - 1].Client = Console.ReadLine();
                            break;
                        case 4: break;
                    }
                }
                
                return choice = -1;
            }

            static int Delete(int choice, string Pub)
            {

                int counter = 0;

                Console.WriteLine("Here are the " + Pub + "'s currently in the system:");
                if (Pub == "Book")
                {
                    if (Books.Count < 1)
                    {
                        Console.WriteLine("There are currently no Books in the System.");
                        return choice = -1;
                    }
                    for (counter = 0; counter < Books.Count; counter++)
                    {
                        Console.WriteLine("\n" + ((counter + 1) + ". ") + Books[counter].Title);
                    }
                    Console.WriteLine("\n Choose which book you would like to remove from inventory: ");
                    counter = Convert.ToInt32(Console.ReadLine());

                    Books.RemoveAt(counter - 1);

                }
                else if (Pub == "Magazine")
                {
                    if (Mags.Count < 1)
                    {
                        Console.WriteLine("There are currently no Magazines in the System.");
                        return choice = -1;
                    }
                    for (counter = 0; counter < Mags.Count; counter++)
                    {
                        Console.WriteLine("\n" + ((counter + 1) + ". ") + Mags[counter].Title);
                    }
                    Console.WriteLine("\n Choose which book you would like to remove from inventory: ");
                    counter = Convert.ToInt32(Console.ReadLine());

                    Mags.RemoveAt(counter - 1);
                }
                else if (Pub == "Ticket")
                {
                    if (Tickz.Count < 1)
                    {
                        Console.WriteLine("There are currently no Tickets in the system.");
                    }
                    for(counter = 0; counter < Tickz.Count; counter++)
                    {
                        Console.WriteLine("\n" + ((counter + 1) + ". ") + Tickz[counter].Description);
                    }
                    Console.WriteLine("\n Choose which ticket you would like to remove from inventory: ");
                    counter = Convert.ToInt32(Console.ReadLine());

                    Tickz.RemoveAt(counter - 1);
                }
                return choice = -1;
            }

              static int Sell(int choice, string Pub, CashTill Sales)
            {
                int counter;
                
             if(Pub == "Book"){
                     if (Books.Count < 1)
                     {
                        Console.WriteLine("There are currently no Books in the System.");
                        return choice = -1;
                     }
                     Console.WriteLine("\nHere is a list of the books: \n");
                
                     for( counter = 0; counter < Books.Count; counter++){
                     Console.WriteLine("\n" + ((counter + 1) + ". ") + Books[counter].Title);                    
                     }      
                     Console.WriteLine("\n ----------------");

                     Console.WriteLine("\nEnter the book number to sell: ");
                     counter = Convert.ToInt32(Console.ReadLine());   
                     Sales.sellItem(Books[counter - 1], Pub);
                           
             }
             else if (Pub == "Magazine")
             {
                 if (Mags.Count < 1)
                 {
                     Console.WriteLine("There are currently no Magazines in the System.");
                     return choice = -1;
                 }
                 Console.WriteLine("\nHere is a list of the magazines: \n");

                 for (counter = 0; counter < Mags.Count; counter++)
                 {
                     Console.WriteLine("\n" + ((counter + 1) + ". ") + Mags[counter].Title);
                 }
                 Console.WriteLine("\n ----------------");

                 Console.WriteLine("\nEnter the magazine number to sell: ");
                 counter = Convert.ToInt32(Console.ReadLine());
                 Sales.sellItem(Mags[counter - 1], Pub);
             }
             else if (Pub == "Ticket")
             {
                 if (Tickz.Count < 1)
                 {
                     Console.WriteLine("There are currently no Tickets in the System.");
                     return choice = -1;
                 }
                 Console.WriteLine("\nHere is a list of the Tickets: \n");

                 for (counter = 0; counter < Tickz.Count; counter++)
                 {
                     Console.WriteLine("\n" + ((counter + 1) + ". ") + Tickz[counter].Description);
                 }
                 Console.WriteLine("\n ----------------");

                 Console.WriteLine("\nEnter the Ticket number to sell: ");
                 counter = Convert.ToInt32(Console.ReadLine());
                 Sales.sellItem(Tickz[counter - 1], Pub);
             }
                return choice = -1;
            }
        }
    }

