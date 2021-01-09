using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_mvc_example.Models
{
    public class Client
    {
        /**
         * Entity framework reconoce la ID. si creamos una propiedad llamada Id o xxId -> ejemplo ContactID
         */
        public int ClientID     { get; set; }
        public string name { get; set; }
        public string company { get; set; } 

    }
}
