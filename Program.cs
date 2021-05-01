using System;

namespace depInject
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Repo obj = new Repo();
            Client c1 = new Client(obj);

           string s1= c1.GetUsernames();
            Console.WriteLine(s1);
            Console.ReadLine();
        }
    }
}
