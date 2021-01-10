using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_mvc_example.Models
{
    public class Product
    {
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
        //Por su puesto tenemos que poner la columna que hereda los datos.
    public int CategoryId { get; set; }


        /**
         * La siguiente es la categoria. FK 
         */
    
        public virtual Category Category { get; set; }
    
    



    }
}
