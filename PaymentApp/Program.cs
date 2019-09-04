using System;

namespace PaymentApp
{
    class Program
    {
        static Account account1 = new Account("Forlong the Fat");
        static Account account2 = new Account("Samwise Gamgee");
        static Account account3 = new Account("Tom Bombadil");

        static Account selected = null;

        static SMUtils.Menu submenu;

        static void Main(string[] args)
        {
            var menu = new SMUtils.Menu();
            menu.AddOption('1', "Select account for Forlong the Fat", SelectAccount1);
            menu.AddOption('2', "Select account for Samwise Gamgee", SelectAccount2);
            menu.AddOption('3', "Select account for Tom Bombadil", SelectAccount3);

            submenu = new SMUtils.Menu();
            submenu.AddOption('1', "Show Account Details", ShowAccountDetails);
            submenu.AddOption('2', "Buy a new Item", BuyItem);

            menu.Start();
        }

        static void SelectAccount1()
        {
            selected = account1;
            submenu.Start();
        }

        static void SelectAccount2()
        {
            selected = account2;
            submenu.Start();
        }

        static void SelectAccount3()
        {
            selected = account3;
            submenu.Start();
        }

        static void ShowAccountDetails()
        {
            Console.WriteLine("Owner: " + selected.Name);
            Console.WriteLine("Items: " + selected.Items);
            Console.WriteLine("Saldo: " + selected.Saldo.ToString("c2"));
        }

        static void BuyItem()
        {
            Console.WriteLine("Trying to buy an item...");
            if (selected.BuyItem())
            {
                Console.WriteLine("Success!");
            } else
            {
                Console.WriteLine("Purchase Failed");
            }
        }
    }
}
