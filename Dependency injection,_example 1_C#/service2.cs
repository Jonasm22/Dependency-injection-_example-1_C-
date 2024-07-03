using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection__example_1_C_
{
    public class service2 : IService
    {
        public void Serve()
        {
            Console.WriteLine("Llamando a service 2");
        }
    }
}
