using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_injection__example_1_C_
{
    public  class client
    {
        private IService _Service;

        public IService Service
        {
            set { _Service = value; }
        }

        //constructor
        public client(IService service)
        {
            _Service = service;

        }


        public void ServeMethod()
        {
            _Service.Serve();
            
        }






    }
}
