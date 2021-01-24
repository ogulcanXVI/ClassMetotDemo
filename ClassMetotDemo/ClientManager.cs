using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ClientManager
    {
        public void Add(Client client)
        {
            Console.WriteLine(client.Name + " Added");
        }
        
        public void Remove (Client client)
        {
            Console.WriteLine(client.Name + " Removed");
        }
        public void List(Client[] clients)
        {
            foreach (var client in clients)
            {
                Console.WriteLine("Client Id: " + client.Id + "Name: " + client.Name + "LastName: " + client.LastName + "LoanType: " + client.LoanType + "LoanDebt: " + client.LoanDebt);
            }
        }
    }
}
