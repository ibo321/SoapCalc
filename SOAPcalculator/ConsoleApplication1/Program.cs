using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.ServiceReference1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceReference1.Service1Client client = new Service1Client("BasicHttpBinding_IService1"))
            {
                Console.WriteLine(client.age(10));
                client.age(10);
            }
        }
    }
}
