using System;
using System.Collections.Generic;
using System.Text;

namespace depInject
{
    public class Repo : IRepo
    {
        public string GetUser()
        {
            return "Hello";
        }
        
    }
}
