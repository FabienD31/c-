using System;
using Microsoft.AspNetCore.Mvc;

namespace queteRoutage.Controllers
{
                                                                        //Routage par Attribut
   
    public class Hello2Controller : ControllerBase
    {
        public String SayHello()
        {
            return "Hello Fabien !";
        }

        public String YellHello()
        {
            return "HELLO tu es trop fort!";
        }
    }
}
