using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client();
            client1.Id = 42;
            client1.Name = " Oğulcan ";
            client1.LastName = " Özdemir ";
            client1.LoanType = " Student Loan ";
            client1.LoanDebt = " 10000";

            Client client2 = new Client();
            client2.Id = 17;
            client2.Name = " Tupac";
            client2.LastName = " Shakur";
            client2.LoanType = "Artist Loan ";
            client2.LoanDebt = " 1500000 ";

            Client client3 = new Client();
            client3.Id = 35;
            client3.Name = " Sezen";
            client3.LastName = " Aksu";
            client3.LoanType = " Artist Loan ";
            client3.LoanDebt = " 500000 ";

            Client[] clients = new[] { client1, client2, client3 };
            ClientManager manager = new ClientManager();
            manager.Add(client1);
            manager.Remove(client2);
            manager.List(clients);

        }
    }
}
