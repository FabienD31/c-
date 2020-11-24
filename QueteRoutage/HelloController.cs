using System;
using Microsoft.AspNetCore.Mvc;


namespace queteRoutage.Controllers
{
                                                                                        //Routage par Convention
    
    public class HelloController : ControllerBase
    {
        [Route("Hello/Say")] // The endpoint here is reached by calling `/Say` route
        public String SayHello()
        {
            return "Hello !";
        }

        [Route("Hello/Yell")] // The endpoint here is reached by calling `/Yell` route
        public String YellHello()
        {
            return "HELLO !";
        }


    }
}
