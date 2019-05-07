using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThrehouseAspNetCore.Services
{
    public class TestService : ITestService
    {
        public String GetAboutContent() 
        {
            return "Here is the about view Content from test service";
        }
    }
}
