using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class CreateCommandDto
    {// primary do not need create it will created by entityframwork while creating 
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }

    }
}
